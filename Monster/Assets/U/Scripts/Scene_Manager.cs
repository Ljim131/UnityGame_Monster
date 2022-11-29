using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Manager : MonoBehaviour
{

    public void start()
    {
        SceneManager.LoadScene("시작화면");
    }
    public void all()
    {
        SceneManager.LoadScene("6_ALL");
    }

    public void Alley()
    {
        SceneManager.LoadScene("골목");
    }

    public void entrance()
    {
        SceneManager.LoadScene("저택입구");
    }

    public void office()
    {
        SceneManager.LoadScene("집무실");
    }

    public void firstfloor_cleaner()
    {
        SceneManager.LoadScene("1층복도_청소부");
    }

    public void laundry_room()
    {
        SceneManager.LoadScene("세탁실");
    }

    public void firstfloor()
    {
        SceneManager.LoadScene("1층복도");
    }

    public void endding()
    {
        SceneManager.LoadScene("야외엔딩");
    }


}