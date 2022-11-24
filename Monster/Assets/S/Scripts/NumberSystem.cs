using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberSystem : MonoBehaviour
{

    private AudioManager theAudio;
    public string key_sound; // 방향키 사운드
    public string enter_sound; // 결정키 사운드
    public string cancel_sound; // 오답 && 취소키 사운드
    public string correct_sound; // 정답 사운드
    public int moveX; // superObject의 x값을 얼마만큼 이동시킬지

    private int count;  // 배열의 크기, 몇 자릿수 -> 1000 이면 3
    private int selectedTextBox; // 선택된 자릿수.
    private int result; // 플레이어가 도출해낸 값.
    private int correctNumber; //정답  => result 와 correctNumber가 일치하면 정답으로 처리

    private string tempNumber;

    public GameObject superObject; //superObject가 가운데 정렬되게 해줌
    public GameObject[] panel; //panel을 필요한 갯수만큼 활성화 시킴
    public Text[] Number_Text;

    public Animator anim;

    public bool activated; //return new waitUntill , 문제를 풀고 다음 이벤트로 넘어갈 수 있게해줌
    private bool keyInput; // 키처리 활성화, 비활성화.
    private bool correctFlag; // 정답인지 아닌지 여부 -> correctNumber와 일치한 result면 correctFlag는 True가 됨

    void Start()
    {
        theAudio = FindObjectOfType<AudioManager>();
    }

    public void ShowNumber(int _correctNumber)
    {
        correctNumber = _correctNumber;
        activated = true;
        correctFlag = false;

        string temp = correctNumber.ToString(); // 받은 숫자를 문자열로 만들어줌 이유-> length라는 속성을 이용하기 위해
        for (int i = 0; i < temp.Length; i++)
        {
            count = i;
            panel[i].SetActive(true); //패널 활성화 갯수
            Number_Text[i].text = "0";
        }

        superObject.transform.position = new Vector3(superObject.transform.position.x + (moveX * count),
                                                     superObject.transform.position.y,
                                                     superObject.transform.position.z);

        selectedTextBox = 0;
        result = 0;
        SetColor();
        anim.SetBool("Appear", true);
        keyInput = true;
    }


    public bool GetResult()
    {
        return correctFlag;
    }

    public void SetNumber(string _arrow)
    {

        int temp = int.Parse(Number_Text[selectedTextBox].text); //선택된 자리수의 텍스트를 Integer 숫자 형식으로 강제 형변환

        if (_arrow == "DOWN")
        {
            if (temp == 0)
                temp = 9;
            else
                temp--;
        }
        else if (_arrow == "UP")
        {
            if (temp == 9)
                temp = 0;
            else
                temp++;
        }
        Number_Text[selectedTextBox].text = temp.ToString();
    }

    public void SetColor()
    {
        Color color = Number_Text[0].color;
        color.a = 0.3f;
        for (int i = 0; i <= count; i++)
        {
            Number_Text[i].color = color;
        }
        color.a = 1f;
        Number_Text[selectedTextBox].color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyInput)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                theAudio.Play(key_sound);
                SetNumber("DOWN");
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                theAudio.Play(key_sound);
                SetNumber("UP");
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                theAudio.Play(key_sound);
                if (selectedTextBox < count)
                    selectedTextBox++;
                else
                    selectedTextBox = 0;
                SetColor();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                theAudio.Play(key_sound);
                if (selectedTextBox > 0)
                    selectedTextBox--;
                else
                    selectedTextBox = count;
                SetColor();
            }
            else if (Input.GetKeyDown(KeyCode.Z)) // 결정키
            {
                theAudio.Play(key_sound);
                keyInput = false;
                StartCoroutine(OXCoroutine());

            }
            else if (Input.GetKeyDown(KeyCode.X)) // 취소키
            {
                theAudio.Play(key_sound);
                keyInput = false;
                StartCoroutine(ExitCoroutine());
            }

        }
    }

    IEnumerator OXCoroutine()
    {
        Color color = Number_Text[0].color;
        color.a = 1f;

        for (int i = count; i >= 0; i--) // 1356이 비번인데 i가 0부터 시작하면 6531 이 되기 때문에 끝 번호부터 하는것
        {
            Number_Text[i].color = color;
            tempNumber += Number_Text[i].text;
        }

        yield return new WaitForSeconds(1f);

        result = int.Parse(tempNumber);

        if (result == correctNumber)
        {
            theAudio.Play(correct_sound);
            correctFlag = true;
        }
        else
        {
            theAudio.Play(cancel_sound);
            correctFlag = false;
        }
        Debug.Log("우리가 낸 답 = " + result + "  정답 = " + correctNumber);
        StartCoroutine(ExitCoroutine());

    }
    IEnumerator ExitCoroutine()
    {
        result = 0;
        tempNumber = "";
        anim.SetBool("Appear", false);

        yield return new WaitForSeconds(0.1f);

        for (int i = 0; i <= count; i++)
        {
            panel[i].SetActive(false);
        }
        superObject.transform.position = new Vector3(superObject.transform.position.x - (moveX * count),
                                                     superObject.transform.position.y,
                                                     superObject.transform.position.z);

        activated = false;
    }
}