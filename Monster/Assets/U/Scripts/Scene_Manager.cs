using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Manager : MonoBehaviour
{

    public void start()
    {
        SceneManager.LoadScene("����ȭ��");
    }
    public void all()
    {
        SceneManager.LoadScene("6_ALL");
    }

    public void Alley()
    {
        SceneManager.LoadScene("���");
    }

    public void entrance()
    {
        SceneManager.LoadScene("�����Ա�");
    }

    public void office()
    {
        SceneManager.LoadScene("������");
    }

    public void firstfloor_cleaner()
    {
        SceneManager.LoadScene("1������_û�Һ�");
    }

    public void laundry_room()
    {
        SceneManager.LoadScene("��Ź��");
    }

    public void firstfloor()
    {
        SceneManager.LoadScene("1������");
    }

    public void endding()
    {
        SceneManager.LoadScene("�߿ܿ���");
    }


}