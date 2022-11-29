
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.SceneManagement;

public class TalkManager : MonoBehaviour

{
    public PlayableDirector playableDirector;
    public TimelineAsset timeline;

    public GameObject[] Comments;
    public Sprite[] portrait;

    public TMP_Text name_tag;
    public TMP_Text text;

    int count = 0;
    int talkstart = 0;

    public void TimeReceiver()
    {
        if (talkstart != 0)
        {
            StopCoroutine(alley1());
            StopCoroutine(alley2());
            StopCoroutine(entrance1());
            StopCoroutine(entrance2());
            StopCoroutine(entrance3());
            StopCoroutine(office());
            StopCoroutine(firstfloor_cleaner());
            StopCoroutine(laundry_room1());
            StopCoroutine(laundry_room2());
            StopCoroutine(firstfloor1());
            StopCoroutine(firstfloor2());
            StopCoroutine(endding1());
            StopCoroutine(endding2());
            StopCoroutine(endding3());

        }
       
        Start_Talk();

        if (SceneManager.GetActiveScene().name == "���")
        {
            if (talkstart == 1)
            {
                StartCoroutine(alley1());
            }

            else if (talkstart == 2)
            {
                StartCoroutine(alley2());
            }
        }

        else if (SceneManager.GetActiveScene().name == "�����Ա�")
        {
            if (talkstart == 1)
            {
                StartCoroutine(entrance1());
            }

            else if (talkstart == 2)
            {
                StartCoroutine(entrance2());
            }

            else if (talkstart == 3)
            {
                StartCoroutine(entrance3());
            }
        }

        else if (SceneManager.GetActiveScene().name == "������")
        {
            StartCoroutine(office());
        }

        else if (SceneManager.GetActiveScene().name == "1������_û�Һ�")
        {
            StartCoroutine(firstfloor_cleaner());
        }

        else if (SceneManager.GetActiveScene().name == "��Ź��")
        {
            if (talkstart == 1)
            {
                StartCoroutine(laundry_room1());
            }
            
            else if (talkstart ==2)
            {
                StartCoroutine(laundry_room2());
            }
        }

        else if (SceneManager.GetActiveScene().name == "1������")
        {
            if (talkstart == 1)
            {
                StartCoroutine(firstfloor1());
            }

            else if (talkstart == 2)
            {
                StartCoroutine(firstfloor2());
            }

            else if (talkstart == 3)
            {
                StartCoroutine(firstfloor3());
            }
        }

        else if (SceneManager.GetActiveScene().name == "�߿ܿ���")
        {
            if (talkstart == 1)
            {
                StartCoroutine(endding1());
            }

            else if (talkstart == 2)
            {
                StartCoroutine(endding2());
            }

            else if (talkstart == 3)
            {
                StartCoroutine(endding3());
            }
        }

    }

    void View_Comment_box()
    {
        Comments[0].SetActive(true);
        Comments[1].SetActive(true);
    }
    void View_CommentNonimg_box()
    {
        Comments[0].SetActive(true);
        Comments[1].SetActive(false);
        name_tag.text = "";
    }
    void Start_Talk()
    {
        playableDirector.playableGraph.GetRootPlayable(0).SetSpeed(0);
        talkstart++;
    }
    void Pause_Talk()
    {
        Comments[0].SetActive(false);
        name_tag.text = "";
        text.text = "";
        playableDirector.playableGraph.GetRootPlayable(0).SetSpeed(1);
    }
    void End_Talk()
    {
        count = 0;
        talkstart = 0;
        Comments[0].SetActive(false);
        name_tag.text = "";
        text.text = "";
        playableDirector.playableGraph.GetRootPlayable(0).SetSpeed(1);
    }

    IEnumerator alley1()
    {
        while (talkstart != 0)
        {
            if (talkstart == 1 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            if(count == 0 )
            {
                View_CommentNonimg_box();
                text.text = "������ ������ ���ذ���.\n������ �����ڵ��� �����ߴ� �ô밡 �Դ�.";
            }

            else if(count == 1)
            {
                text.text = "�Դٰ� �׵��� �Ǻ� ���� �������� ���Ͽ�\n����� ������ �� �Ȱ��ٴ� ���̴�.";
            }

            else if (count == 2)
            {
               
                text.text = "������ �پ���� �ȵ���̵��� �ô��̴�.";
            }

            else if(count == 3)
            {
                
                text.text = "(���������� �����̴� ���� ������ ����� ���δ�.)";
            }

            else if (count == 4 )
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "��... �̹����� ���� �ż��ΰ�?";
            }

            else if (count == 5)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "�ȵ���̵���� ���ڸ��� �������鼭\n�׳��� �ܿ� �ٴϴ� ���帶�� ©���� ���Ҿ.";
            }

            else if (count == 6)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "���п� �� �̻� ������ �� ���� �� �i�ܳ� �ż���ϡ�.";
            }

            else if (count == 7)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "���ҡ�. �� �ȵ���̵� �� �༮�� �����̾ߡ�.";
            }

            else if (count == 8)
            {
                Pause_Talk();
                break;
            }

            yield return null;
        }

    }
    IEnumerator alley2()
    {
        while (talkstart != 0)
        {
            if (talkstart == 2 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            if (count == 8)
            {
                View_CommentNonimg_box();
                text.text = "(�ż� ��ź�� �ϸ� ���� �ȴ� ���ΰ���\n�쿬�� ���� �پ��ִ� ������ ����.)";

            }

            else if (count == 9)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "Ÿ�� ����...?\n��û ���� ���ܸ� ��� �ƴѰ�?";
            }

            else if (count == 10)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "û��..���� �ȵ���̵�.. ?!\n��, ��ó���ϰ� ���. ";
            }

            else if (count == 11)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "�� �ȵ���̵�?";
            }

            else if (count == 12)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "...";
            }

            else if (count == 13)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "�Ļ� �� ���� ����???";
            }


            else if (count == 14)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "���, �µ�ó�� �ϰ���..\n�� �³׶� �����Ҽ��� �����ʳ�?";
            }

            else if (count == 15)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "�� �ƴϸ� ����.\n���ְ� �ڰ����ָ� ������� �� �� �ִ� ��¥.";
            }

            else if (count == 16)
            {
                End_Talk();
            }

            yield return null;
        }

    }

    IEnumerator entrance1()
    {
        while (talkstart != 0)
        {
            if (talkstart == 1 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            if (count == 0 )
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                text.text = "������ ���� ���.. �װ� �ٷ� ��..��";

            }

            else if (count == 1)
            {
                View_CommentNonimg_box();
                text.text = "(���ÿ� �� ���ΰ��� ���� ����� ��ġ�� �ִ�\n�ȵ���̵忡�� ���� �����.)";
            }

            else if (count == 2)
            {
                Pause_Talk();
                break;
            }

            yield return null;
        }

    }
    IEnumerator entrance2()
    {
        while (talkstart != 0 )
        {
            if (talkstart == 2 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            if (count == 2 )
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "�ȳ��ϼ���? ���ΰ��� ���� �Խ��ϴ�.\nû�Һ� �����Ͻ���? ���� ���� �ɱ��?";
            }

            else if (count == 3)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[3];
                name_tag.text = "<#33FF33>��������1</color>";
                text.text = "�ȳ��ϼ���. �������� ������.\n�Ƹ� �ű⼭ ��� �ȳ����̴ٰϴ�.";
            }

            else if (count == 4)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "�����մϴ�. �� ���� ���ϰ� �ͳ׿�~";
            }

            else if (count == 5 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[3];
                name_tag.text = "<#33FF33>��������1</color>";
                text.text = "... ��.";
            }

            else if (count == 6 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "'����, ������.. ����ϰ� �����ǰ�?'";
            }

            else if (count == 7 )
            {
                View_CommentNonimg_box();
                text.text = "(���ΰ��� �ȵ���̵带 �ڷ��ϰ� ���� �Ա��� ���Ѵ�.)";

            }

            else if (count == 8)
            {
                Pause_Talk();
                break;
            }

            yield return null;
        }

    }
    IEnumerator entrance3()
    {
        while (talkstart != 0 )
        {
            if (talkstart == 3 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            if (count == 8 )
            {
                View_CommentNonimg_box();
                text.text = "�װ��� Ű�� ũ�� ��ġ�� ū �ȵ���̵尡 �� �� �־���.";
            }

            else if (count == 9 )
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>��� �ȵ���̵�</color>";
                text.text = "�����Ϸ� ���̳���?";
            }

            else if (count == 10 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "���ΰ��� ���� �Ծ��.\nû�Һο�.";
            }

            else if (count == 11 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>��� �ȵ���̵�</color>";
                text.text = "ȯ���մϴ�. ���δ��� �������� 2���Դϴ�.\n������ʼ�.";
            }

            else if (count == 12)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "�� �����մϴ�.\n�� Ȥ�� �̸���?";
            }

            else if (count == 13)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>��� �ȵ���̵�</color>";
                text.text = "���� ���� �������� �������Դϴ�.\n�����Ͻʼ�.";
            }

            else if (count == 14)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "�׷�����.\nù�������ݾƿ�";
            }

            else if (count == 15)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>��� �ȵ���̵�</color>";
                text.text = "�����Դϴ�.";
            }

            else if (count == 16)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "������, ���׾�";
            }

            else if (count == 17)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>��� �ȵ���̵�</color>";
                text.text = "...";
            }

            else if (count == 18)
            {
                View_CommentNonimg_box();
                text.text = "(���ΰ��� ��ġ ū �ȵ���̵带 ���� 2������ ���Ѵ�.)";
            }

            else if (count == 19)
            {
                End_Talk();
            }

            yield return null;
        }

    }
    IEnumerator office()
    {
        while (talkstart != 0)
        {
            if (talkstart == 1 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            if (count == 0)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<#33FF33>��Ÿ��</color>";
                text.text = "�ݰ�����. �̸���?";

            }

            else if (count == 1)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "--- �Դϴ�.";
            }

            else if (count == 2)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<#33FF33>��Ÿ��</color>";
                text.text = "�׷����� ---��. û��, �Ϸ� ���Ű���? ��~\nû���� �̹����� �ƴϽŵ�...";
            }

            else if (count == 3)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = ".... ";
            }

            else if (count == 4)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "������°ž� ?��";
            }

            else if (count == 5 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<#33FF33>��Ÿ��</color>";
                text.text = "���� ���� ����׿�.\n���� ���ú��� ���� ���Ͻ���.";
            }

            else if (count == 6)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "���ΰ�";
                text.text = "��. �����մϴ�.";
            }

            else if (count == 7 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<#33FF33>��Ÿ��</color>";
                text.text = "������ �ȳ��ص帮�� �� ���� ������.\n���� �Ʊ�����.";
            }

            else if (count == 8 )
            {
                View_CommentNonimg_box();
                text.text = "(���ΰ��� ��ġ ū �ȵ���̵带 ���� 2������ ��������.)";
            }

            else if (count == 9 )
            {
                End_Talk();
            }

            yield return null;
        }

    }
    IEnumerator firstfloor_cleaner()
    {
        while (talkstart != 0)
        {
            if (talkstart == 1 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            if (count == 0)
            {
                View_CommentNonimg_box();
                text.text = "û�� �ȵ���̵忡�� ���� ���� ���ΰ���\nȯ�� �� �ٷ� 2�� ���� û�Ҹ� �ϰ� �Ǿ���.";

            }

            else if (count == 1)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = " ����, �̸���... ������?";
            }

            else if (count == 2)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>û�� �ȵ���̵�</color>";
                text.text = "�׸��Դϴ�.";
            }

            else if (count == 3)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>û�� �ȵ���̵�</color>";
                text.text = "---��?";
            }

            else if (count == 4)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "�� �¾ƿ�!";
            }


            else if (count == 5)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "�� �׸���. ���� ���� �׷�����?";
            }

            else if (count == 6)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "���� ��¦ �������Ͱ��ƿ�.";
            }

            else if (count == 7)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>û�� �ȵ���̵�</color>";
                text.text = "��...";
            }

            else if (count == 8)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>û�� �ȵ���̵�</color>";
                text.text = "��,";
            }

            else if (count == 9)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>û�� �ȵ���̵�</color>";
                text.text = "...........";
            }

            else if (count == 10)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>û�� �ȵ���̵�</color>";
                text.text = "���ұ��?";
            }

            else if (count == 11)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "��.";
            }

            else if (count == 12)
            {
                End_Talk();
            }

            yield return null;
        }

    }
    IEnumerator laundry_room1()
    {
        while (talkstart != 0)
        {
            if (talkstart == 1 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            else if (count == 0)
            {
                View_CommentNonimg_box();
                text.text = "û�� �ȵ���̵��� �ȿ� ���� �� �κ��� �־� ������\nģ�������� ��ȭ�� ��������";
            }

            else if (count == 1)
            {
                View_CommentNonimg_box();
                text.text = "��ȭ�� �����Ǿ��� ���ΰ��� û�Ҹ� ��� �Ͽ���.";
            }

            else if (count == 2)
            {
                View_CommentNonimg_box();
                text.text = "������ ���ΰ����Դ�\n������ û������ ���ſ� �� �˾�����,";
            }

            else if (count == 3)
            {
                View_CommentNonimg_box();
                text.text = "������ �� �ǰ��� �����̾��⿡\n��Ż�ϰ� ù���� ���� �� �־���.";
            }

            else if (count == 4)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "�������� ���Ϸ��� �¸��� �����ϳ�..\n�� �� ���ð� �;߰ڴ�.";
            }

            else if (count == 5)
            {
                View_CommentNonimg_box();
                text.text = "(���� ���� ������ ���� ���ΰ�, \n����ϰ� �Һ��� ������� ���� ���� �� ������ ���Ѵ�.)";
            }

            else if (count == 6)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = " ������ ����?";
            }

            else if (count == 7)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = " ���� ���ڳ�?";
            }

            else if (count == 8)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = " ��..!";
            }

            else if (count == 9)
            {
                View_CommentNonimg_box();
                text.text = "(����� ����� ���ΰ��� ��� �Ҹ��� �´�.)";
            }

            else if (count == 10)
            {
                View_Comment_box();
                Comments[1].SetActive(false);
                name_tag.text = "<#33FF33>???</color>";
                text.text = " .........";
            }


            else if (count == 11)
            {
                View_Comment_box();
                Comments[1].SetActive(false);
                name_tag.text = "<color=red>???</color>";
                text.text = " ��ƿ�.";
            }

            else if (count == 12)
            {
                Pause_Talk();
                break;
            }

            yield return null;
        }

    }
    IEnumerator laundry_room2()
    {
        while (talkstart != 0)
        {
            if (talkstart == 2 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            else if (count == 12)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "�̰ų�!!";
            }

            else if (count == 13)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>��Ÿ��</color>";
                text.text = ".....!!";
            }

            else if (count == 14)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>��Ÿ��</color>";
                text.text = "��, �ȵ���̵尡 �ƴϱ���?";
            }

            else if (count == 15)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "���... ��ü ����, �� �̷�����!";
            }

            else if (count == 16)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>��Ÿ��</color>";
                text.text = "����̸� ��, ���� ���� �ʿ� �ֳ�...";
            }

            else if (count == 17)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>��Ÿ��</color>";
                text.text = "���ϰ����� ����.";
            }

            else if (count == 18)
            {
                View_CommentNonimg_box();
                text.text = "(���ΰ��� ��ȣ �ȵ���̵� �� �뿡�� �̲��� ���ϰ����� ������.)";
            }


            else if (count == 19)
            {
                View_CommentNonimg_box();
                text.text = "(���ΰ��� ��ȣ �ȵ���̵� �� �뿡�� �̲��� ���ϰ����� ������.)";
            }

            else if (count == 20)
            {
                End_Talk();
            }

            yield return null;
        }

    }
    IEnumerator firstfloor1()
    {
        while (talkstart != 0)
        {
            if (talkstart == 1 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            if (count == 0)
            {
                View_CommentNonimg_box();
                text.text = "���� -";
            }

            else if (count == 1)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "����. �� �ȿ�����?";
            }

            else if (count == 2)
            {
                View_CommentNonimg_box();
                text.text = "�������� �ɾ���� �Ҹ��� ����.";
            }

            else if (count == 3)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "�ϴ� ����.";
            }

            else if (count == 4)
            {
                Pause_Talk();
                break;
            }

            yield return null;
        }

    }
    IEnumerator firstfloor2()
    {
        while (talkstart != 0)
        {
            if (talkstart == 2 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            else if (count == 4)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>��Ÿ��</color>";
                text.text = "�� ƴ��Ÿ�� ������ ��?";
            }

            else if (count == 5)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>��Ÿ��</color>";
                text.text = "����� ���� ��. ";
            }

            else if (count == 6)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>��Ÿ��</color>";
                text.text = "���� ���� ���ƿ��� ������ �� ���տ� ��ü ������.";
            }

            else if (count == 7)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[5];
                name_tag.text = "<color=red>��ȣ �ȵ���̵� 1,2</color>";
                text.text = "��.";
            }

            else if (count == 8)
            {
                Pause_Talk();
                break;
            }

            yield return null;
        }

    }
    IEnumerator firstfloor3()
    {
        while (talkstart != 0)
        {
            if (talkstart == 3 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            else if (count == 8)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "�����...";
            }

            else if (count == 9)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "���ι濡 �ְڱ�";
            }

            else if (count == 10)
            {
                End_Talk();
            }
            yield return null;
        }

    }
    IEnumerator endding1()
    {
        while (talkstart != 0)
        {
            if (talkstart == 1 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            else if (count == 0)
            {
                View_CommentNonimg_box();
                text.text = "Ÿ�� ���ÿ��� Ż������ 5���̶�� �ð��� �귶��.";
            }

            else if (count == 1)
            {
                View_CommentNonimg_box();
                text.text = "�� �ָ� ���� �� ���� ��� �Ǿ���\n�׳��� ���� �� �������Ե� ������ �ʾҴ�.";
            }

            else if (count == 2)
            {
                View_CommentNonimg_box();
                text.text = "�� ���� �� ������ �����,\n���� �־� �ٽ� �ѹ� �� ���׷� ���� �Ǿ���.";
            }

            else if (count == 3)
            {
                Pause_Talk();
                break;
            }
            yield return null;
        }

    }
    IEnumerator endding2()
    {
        while (talkstart != 0)
        {
            if (talkstart == 2 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            else if (count == 3)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "��, ����� ! ...";
            }

            else if (count == 4)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "�������̳�";
            }

            else if (count == 5)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "�������̳�";
            }

            else if (count == 6)
            {
                View_CommentNonimg_box();
                text.text = "Ÿ�� ������ ������ ������ �����̾�����\n��¾�� �ȿ��� ���� ���� ���� �ʾҴ�.";
            }

            else if (count == 7)
            {
                View_CommentNonimg_box();
                text.text = "���� �� ��ü�� ������ ��� �Ҹ��� ��ĥ ��������.";
            }

            else if (count == 8)
            {
                Pause_Talk();
                break;
            }
            yield return null;
        }

    }
    IEnumerator endding3()
    {
        while (talkstart != 0)
        {
            if (talkstart == 3 && Input.GetKeyDown(KeyCode.Return))
            {
                count++;
            }

            else if (count == 8)
            {

                View_CommentNonimg_box();
                text.text = "(��ȭ�� �Ҹ�, ��ȭ�� �޴� ���ΰ�)";
            }

            else if (count == 9)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "�� ��, �븮��.";
            }

            else if (count == 10)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "���� �����ֽ��ϴ�.";
            }

            else if (count == 11)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "���ΰ�";
                text.text = "��~";
            }

            else if (count == 12)
            {
                End_Talk();
            }
            yield return null;
        }

    }

}
