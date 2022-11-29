
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

        if (SceneManager.GetActiveScene().name == "골목")
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

        else if (SceneManager.GetActiveScene().name == "저택입구")
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

        else if (SceneManager.GetActiveScene().name == "집무실")
        {
            StartCoroutine(office());
        }

        else if (SceneManager.GetActiveScene().name == "1층복도_청소부")
        {
            StartCoroutine(firstfloor_cleaner());
        }

        else if (SceneManager.GetActiveScene().name == "세탁실")
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

        else if (SceneManager.GetActiveScene().name == "1층복도")
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

        else if (SceneManager.GetActiveScene().name == "야외엔딩")
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
                text.text = "세상은 빠르게 변해간다.\n수많은 과학자들이 예측했던 시대가 왔다.";
            }

            else if(count == 1)
            {
                text.text = "게다가 그들은 피부 구현 성공으로 인하여\n사람과 구별이 잘 안간다는 점이다.";
            }

            else if (count == 2)
            {
               
                text.text = "지금은 바야흐로 안드로이드의 시대이다.";
            }

            else if(count == 3)
            {
                
                text.text = "(쓰레기통을 뒤적이는 거지 차림의 사람이 보인다.)";
            }

            else if (count == 4 )
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "하... 이번에도 깡통 신세인가?";
            }

            else if (count == 5)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "안드로이드들이 일자리를 가져가면서\n그나마 겨우 다니던 직장마저 짤리고 말았어….";
            }

            else if (count == 6)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "덕분에 더 이상 월세도 못 내고 곧 쫒겨날 신세라니….";
            }

            else if (count == 7)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "망할…. 다 안드로이드 그 녀석들 때문이야….";
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
                text.text = "(신세 한탄을 하며 길을 걷던 주인공은\n우연히 벽에 붙어있는 공고문을 본다.)";

            }

            else if (count == 9)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "타스 가문...?\n엄청 부자 아줌마 기업 아닌가?";
            }

            else if (count == 10)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "청소..조건 안드로이드.. ?!\n허, 어처구니가 없어서. ";
            }

            else if (count == 11)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "또 안드로이드?";
            }

            else if (count == 12)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "...";
            }

            else if (count == 13)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "식사 및 숙소 제공???";
            }


            else if (count == 14)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "잠깐, 걔들처럼 하고가면..\n날 걔네라 생각할수도 있지않나?";
            }

            else if (count == 15)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "모 아니면 도다.\n밥주고 자게해주면 엄마라고도 할 수 있다 진짜.";
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
                text.text = "‘감정 없는 사람.. 그건 바로 나..’";

            }

            else if (count == 1)
            {
                View_CommentNonimg_box();
                text.text = "(저택에 들어선 주인공은 가장 가까운 위치에 있는\n안드로이드에게 길을 물어본다.)";
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
                name_tag.text = "주인공";
                text.text = "안녕하세요? 구인공고 보고 왔습니다.\n청소부 모집하시죠? 어디로 가면 될까요?";
            }

            else if (count == 3)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[3];
                name_tag.text = "<#33FF33>정원관리1</color>";
                text.text = "안녕하세요. 정문으로 가세요.\n아마 거기서 경비가 안내해줄겁니다.";
            }

            else if (count == 4)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "감사합니다. 꼭 같이 일하고 싶네요~";
            }

            else if (count == 5 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[3];
                name_tag.text = "<#33FF33>정원관리1</color>";
                text.text = "... 네.";
            }

            else if (count == 6 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "'뭐야, 반응이.. 퇴근하고 싶은건가?'";
            }

            else if (count == 7 )
            {
                View_CommentNonimg_box();
                text.text = "(주인공은 안드로이드를 뒤로하고 저택 입구로 향한다.)";

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
                text.text = "그곳엔 키가 크고 덩치가 큰 안드로이드가 한 대 있었다.";
            }

            else if (count == 9 )
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>경비 안드로이드</color>";
                text.text = "무슨일로 오셨나요?";
            }

            else if (count == 10 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "구인공고 보고 왔어요.\n청소부요.";
            }

            else if (count == 11 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>경비 안드로이드</color>";
                text.text = "환영합니다. 주인님의 집무실은 2층입니다.\n따라오십쇼.";
            }

            else if (count == 12)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "아 감사합니다.\n저 혹시 이름이?";
            }

            else if (count == 13)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>경비 안드로이드</color>";
                text.text = "저희가 따로 만날일은 없을것입니다.\n수고하십쇼.";
            }

            else if (count == 14)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "그래도요.\n첫만남이잖아요";
            }

            else if (count == 15)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>경비 안드로이드</color>";
                text.text = "드라그입니다.";
            }

            else if (count == 16)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "고마워요, 드라그씨";
            }

            else if (count == 17)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[6];
                name_tag.text = "<#33FF33>경비 안드로이드</color>";
                text.text = "...";
            }

            else if (count == 18)
            {
                View_CommentNonimg_box();
                text.text = "(주인공은 덩치 큰 안드로이드를 따라 2층으로 향한다.)";
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
                name_tag.text = "<#33FF33>나타스</color>";
                text.text = "반가워요. 이름이?";

            }

            else if (count == 1)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "--- 입니다.";
            }

            else if (count == 2)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<#33FF33>나타스</color>";
                text.text = "그렇군요 ---씨. 청소, 하러 오신거죠? 음~\n청소할 이미지는 아니신데...";
            }

            else if (count == 3)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = ".... ";
            }

            else if (count == 4)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "‘뭐라는거야 ?’";
            }

            else if (count == 5 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<#33FF33>나타스</color>";
                text.text = "제가 말이 길었네요.\n당장 오늘부터 같이 일하시죠.";
            }

            else if (count == 6)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[8];
                name_tag.text = "주인공";
                text.text = "네. 감사합니다.";
            }

            else if (count == 7 )
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<#33FF33>나타스</color>";
                text.text = "방으로 안내해드리고 옷 갈아 입히렴.\n얼굴이 아깝구나.";
            }

            else if (count == 8 )
            {
                View_CommentNonimg_box();
                text.text = "(주인공은 덩치 큰 안드로이드를 따라 2층으로 내려간다.)";
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
                text.text = "청소 안드로이드에게 옷을 받은 주인공은\n환복 후 바로 2층 복도 청소를 하게 되었다.";

            }

            else if (count == 1)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = " 저기, 이름이... 뭐였죠?";
            }

            else if (count == 2)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>청소 안드로이드</color>";
                text.text = "네릭입니다.";
            }

            else if (count == 3)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>청소 안드로이드</color>";
                text.text = "---씨?";
            }

            else if (count == 4)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "네 맞아요!";
            }


            else if (count == 5)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "아 네릭씨. 팔이 원래 그런가요?";
            }

            else if (count == 6)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "색이 살짝 벗겨진것같아요.";
            }

            else if (count == 7)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>청소 안드로이드</color>";
                text.text = "아...";
            }

            else if (count == 8)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>청소 안드로이드</color>";
                text.text = "네,";
            }

            else if (count == 9)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>청소 안드로이드</color>";
                text.text = "...........";
            }

            else if (count == 10)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[2];
                name_tag.text = "<#33FF33>청소 안드로이드</color>";
                text.text = "일할까요?";
            }

            else if (count == 11)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "넵.";
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
                text.text = "청소 안드로이드의 팔에 녹이 슨 부분이 있어 보여서\n친해지고자 대화를 나눴지만";
            }

            else if (count == 1)
            {
                View_CommentNonimg_box();
                text.text = "대화는 단절되었고 주인공은 청소를 계속 하였다.";
            }

            else if (count == 2)
            {
                View_CommentNonimg_box();
                text.text = "나태한 주인공에게는\n간단한 청소조차 버거울 줄 알았으나,";
            }

            else if (count == 3)
            {
                View_CommentNonimg_box();
                text.text = "관리가 잘 되가던 저택이었기에\n무탈하게 첫날을 보낼 수 있었다.";
            }

            else if (count == 4)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "오랜만에 일하려니 온몸이 뻐근하네..\n물 좀 마시고 와야겠다.";
            }

            else if (count == 5)
            {
                View_CommentNonimg_box();
                text.text = "(목이 말라 복도로 나선 주인공, \n희미하게 불빛이 새어나오는 방을 보곤 그 방으로 향한다.)";
            }

            else if (count == 6)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = " 저방은 뭐지?";
            }

            else if (count == 7)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = " 아직 안자나?";
            }

            else if (count == 8)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = " 헉..!";
            }

            else if (count == 9)
            {
                View_CommentNonimg_box();
                text.text = "(방안을 목격한 주인공은 놀란 소리를 냈다.)";
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
                text.text = " 잡아와.";
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
                name_tag.text = "주인공";
                text.text = "이거놔!!";
            }

            else if (count == 13)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>나타스</color>";
                text.text = ".....!!";
            }

            else if (count == 14)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>나타스</color>";
                text.text = "너, 안드로이드가 아니구나?";
            }

            else if (count == 15)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "당신... 대체 뭐야, 왜 이런짓을!";
            }

            else if (count == 16)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>나타스</color>";
                text.text = "사람이면 뭐, 굳이 힘쓸 필요 있나...";
            }

            else if (count == 17)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>나타스</color>";
                text.text = "지하감옥에 가둬.";
            }

            else if (count == 18)
            {
                View_CommentNonimg_box();
                text.text = "(주인공은 경호 안드로이드 두 대에게 이끌려 지하감옥에 갇힌다.)";
            }


            else if (count == 19)
            {
                View_CommentNonimg_box();
                text.text = "(주인공은 경호 안드로이드 두 대에게 이끌려 지하감옥에 갇힌다.)";
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
                text.text = "덜컥 -";
            }

            else if (count == 1)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "뭐야. 왜 안열리지?";
            }

            else if (count == 2)
            {
                View_CommentNonimg_box();
                text.text = "누군가가 걸어오는 소리가 난다.";
            }

            else if (count == 3)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "일단 숨자.";
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
                name_tag.text = "<color=red>나타스</color>";
                text.text = "그 틈을타서 도망을 쳐?";
            }

            else if (count == 5)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>나타스</color>";
                text.text = "쥐새끼 같은 것. ";
            }

            else if (count == 6)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[7];
                name_tag.text = "<color=red>나타스</color>";
                text.text = "내일 내가 돌아오기 전까지 내 눈앞에 시체 가져와.";
            }

            else if (count == 7)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[5];
                name_tag.text = "<color=red>경호 안드로이드 1,2</color>";
                text.text = "네.";
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
                name_tag.text = "주인공";
                text.text = "열쇠는...";
            }

            else if (count == 9)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "주인방에 있겠군";
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
                text.text = "타스 저택에서 탈출한지 5년이라는 시간이 흘렀다.";
            }

            else if (count == 1)
            {
                View_CommentNonimg_box();
                text.text = "난 멀리 떠나 새 삶을 살게 되었고\n그날의 일을 그 누구에게도 말하지 않았다.";
            }

            else if (count == 2)
            {
                View_CommentNonimg_box();
                text.text = "그 이후 새 직장을 얻었고,\n일이 있어 다시 한번 그 동네로 가게 되었다.";
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
                name_tag.text = "주인공";
                text.text = "어, 여기는 ! ...";
            }

            else if (count == 4)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "오랜만이네";
            }

            else if (count == 5)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "오랜만이네";
            }

            else if (count == 6)
            {
                View_CommentNonimg_box();
                text.text = "타스 저택은 여전히 웅장한 저택이었지만\n어쩐지 안에는 벌레 조차 있지 않았다.";
            }

            else if (count == 7)
            {
                View_CommentNonimg_box();
                text.text = "적막 그 자체의 저택은 어딘가 소름이 끼칠 정도였다.";
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
                text.text = "(전화벨 소리, 전화를 받는 주인공)";
            }

            else if (count == 9)
            {
                View_Comment_box();
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "아 네, 대리님.";
            }

            else if (count == 10)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "지금 가고있습니다.";
            }

            else if (count == 11)
            {
                Comments[1].GetComponent<Image>().sprite = portrait[9];
                name_tag.text = "주인공";
                text.text = "네~";
            }

            else if (count == 12)
            {
                End_Talk();
            }
            yield return null;
        }

    }

}
