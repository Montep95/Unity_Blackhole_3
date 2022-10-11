using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement; // Retry Scene ������ ����

public class gameManager : MonoBehaviour
{
    // ���� ���� **
    public GameObject star;
    public GameObject b_star;

    public Text scoreText;
    public Text timeText;
    public Text StageResult;
    public Text TotalResult;
    public Text StageText;

    public GameObject stage;
    public GameObject result;
    public GameObject panel;
    public GameObject Player;
    public GameObject g_field;
    public GameObject goal;

    float limit = 60.0f; // time Text

    Camera cam;

    public G_field gf;
    public Player player;
    public Trajectory trajectory;

    // SerializeField -> None ���� (2022-10-05 22:17)
    //[SerializeField] public float pushForce = 1.0f;
    public float pushForce = 1.0f;

    bool isDragging = false;

    Vector2 startPoint;
    Vector2 endPoint;
    public Vector2 direction;
    Vector2 force;
    float distance;

    int totalScore = 0; // ���� UI
    // ���� ���� **

    // Stage Management
    public int totalPoint;
    public int stagePoint;
    public int stageIndex;
    public GameObject[] Stages;


    #region Singleton class: gamaManager

    // ����UI
    public static gameManager I;

    void Awake()
    {
        // ���� UI
        I = this;
        /*
        if (Instance == null)
        {
            Instance = this;
        }
        */
    }
    #endregion

    // retry ���� ��� 'Time'�� �����
    void initGame()
    {
        Time.timeScale = 1.0f;
        limit = 60.0f;
        totalScore = 0;
    }

    /*
    // �������� ���� �� ������ �ʱⰪ
    void StartStage()
    {
        Time.timeScale = 1.0f;
        // totalScore = 0;
    }

    public void NextStage()
    {
        // Change Stage
        if (stageIndex < Stages.Length - 1)
        {
            stage.SetActive(false);
            Stages[stageIndex].SetActive(false);
            stageIndex++;

            StageResult.text = totalScore.ToString();

            Stages[stageIndex].SetActive(true);
            StageText.text = (stageIndex+1).ToString();
            StartStage();
        }

        // test - ������ �������� �ǹ�Ÿ�� 
        //else if(stageIndex == 2)
        //{
        //    StartStage();
        //    goal.SetActive(false);
        //}

        // Game Clear
        else
        {
            stage.SetActive(false);
            result.SetActive(true);
            Time.timeScale = 0.0f; // ����Ƽ �ð� ����
            Debug.Log("Game Clear !");
        }

        // Calculate Point
        totalPoint += totalScore;
        TotalResult.text = totalPoint.ToString();
        totalScore = 0;
    }
    */
    void Start()
    {
        initGame(); // �����Ҷ����� initGame ȣ��� 'time, score' �ʱ�ȭ�� ����
        cam = Camera.main;
        player.DesactivateRb();

        // �� ������
        //InvokeRepeating("makeStar", 0.0f, 0.2f); // 0�� �Ŀ� �����Ͽ� 0.2�ʸ��� ����


        // ū �� ������
        InvokeRepeating("makeb_Star", 3.0f, 3.0f); // 3�� �Ŀ� �����Ͽ� 4�ʸ��� ����
    }
    void makeStar()
    {
        //Instantiate(star);
    }

    void makeb_Star()
    {
        Instantiate(b_star);
    }

    // Update is called once per frame
    void Update()
    {
        // ���콺 ���� Ŭ��
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            OnDragStart();
        }

        // ���콺 ���� Ŭ�� ��������
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            OnDragEnd();
        }

        // ���콺 �巡��
        if (isDragging)
        {
            OnDrag();
        }

        /*
        // �ð� ���� �ڵ� - �����÷��̸� ���� OFF
        limit -= Time.deltaTime; // �����Ӹ��� �ð��� ������
        if (limit < 0)
        {
            limit = 0.0f;
            panel.SetActive(true);
            Time.timeScale = 0.0f; // Unity ��� �ð� Stop
        }
        timeText.text = limit.ToString("N2");
        */
        
    }

    void OnDragStart()
    {
        player.DesactivateRb();
        startPoint = cam.ScreenToWorldPoint(Input.mousePosition);

        trajectory.Show();
    }

    public void OnDrag()
    {
        endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
        distance = Vector2.Distance(startPoint, endPoint);
        direction = (startPoint - endPoint).normalized;
        force = direction * distance * pushForce;


        Debug.DrawLine(startPoint, endPoint);


        trajectory.UpdateDots(player.pos, force);
    }

    // �巡�װ� ���������� ȣ�� (���ڸ� ������ ���������� ����)
    void OnDragEnd()
    {
        // Player.cs �� ActivateRb()�Լ� ȣ�� = localScale ���� �κ� �ּ�ó��
        player.ActivateRb();
        player.Push(force);

        trajectory.Hide();
    }


    // �ٽ��ϱ� ����
    public void retry()
    {
        SceneManager.LoadScene("myproject");
    }

    /*
    // �����÷��̸� ���� OFF
    // ���� UI
    public void addScore(int score)
    {
        totalScore += score;
        scoreText.text = totalScore.ToString();

        // ���� ���� �����Ǹ� ���� �������� �̵�
        if (totalScore >= 30)
        {
            stage.SetActive(true);
            Time.timeScale = 0.0f;
            
            if(stageIndex == 2)
            {
                NextStage();
            }
        }
    }
    */

    /*
    public void minusScore(int score)
    {
        totalScore -= score;
        scoreText.text = totalScore.ToString();
    }
    */

}
