using UnityEngine;

public class RobotController : MonoBehaviour
{
    public Animator             m_BodyAni;
    public Animator             m_FaceAni;

    public SkinnedMeshRenderer  m_EyeRendererMaterial;
    public Mesh[]               m_EyeMesh;

    public SkinnedMeshRenderer  m_MouseRendererMaterial;
    public Mesh[]               m_MouseMesh;

    public Animator m_Question;
    public Animator m_Surprise;

    public bool isThinking = false;

    public bool m_HiCheck       = false;
    public bool m_ThinkCheck    = false;
    public bool m_HappyCheck    = false;
    public bool m_FunyCheck     = false;
    public bool m_LoverCheck    = false;
    public bool m_WinkCheck     = false;
    public bool m_WrongCheck    = false;
    public bool m_SurpriseCheck = false;
    public bool m_ErrorCheck    = false;

    public int m_RandomSet;

    void Start()
    {

    }

    void Update()
    {
        //if ( Input.GetKeyDown( KeyCode.A ) )
        //{
        //    AniController();
        //}
        if ( m_HiCheck )
        {
            AnimatorStateInfo infoB = m_BodyAni.GetCurrentAnimatorStateInfo(0);

            if ( infoB.IsName("hi") && infoB.normalizedTime >= 1.0f )
            {
                Idle();
                m_HiCheck = false;
            }
        }

        if ( m_ThinkCheck )
        {
            AnimatorStateInfo infoB = m_BodyAni.GetCurrentAnimatorStateInfo(0);
            AnimatorStateInfo infoQ = m_Question.GetCurrentAnimatorStateInfo(0);

            /*if ( infoB.IsName("think") && infoB.normalizedTime >= 1.0f )
            {
                Idle();
                m_Question.gameObject.SetActive(false);
                m_ThinkCheck = false;
            }*/
            float currentTime = infoB.normalizedTime % 1.0f;

            if(isThinking)
            {
                if(m_BodyAni.GetFloat("animSpeed") > 0 && currentTime >= 0.7f)
                {
                    m_BodyAni.SetFloat("animSpeed", -1f);
                    m_FaceAni.SetFloat("animSpeed", -1f);
                }
                else if(m_BodyAni.GetFloat("animSpeed") < 0 && currentTime <= 0.3f)
                {
                    m_BodyAni.SetFloat("animSpeed", 1f);
                    m_FaceAni.SetFloat("animSpeed", 1f);
                }

                if(infoQ.IsName("Question") && infoQ.normalizedTime >= 0.8f)
                {
                    m_Question.speed = 0;
                }
                
            }
            else
            {
                m_Question.speed = 1f;
                m_BodyAni.SetFloat("animSpeed", 1f);
                m_FaceAni.SetFloat("animSpeed", 1f);

                if (m_Question.gameObject.activeSelf)
                {
                    m_Question.gameObject.SetActive(false);
                }
                m_Question.Play("Question", 0, 0.8f);

                m_ThinkCheck = false;
                /*if(infoB.IsName("think") && infoB.normalizedTime >= 1.0f)
                {
                    Idle();
                    m_Question.gameObject.SetActive(false);
                    m_ThinkCheck = false;
                }*/
            }

        }

        if ( m_HappyCheck )
        {
            AnimatorStateInfo infoB = m_BodyAni.GetCurrentAnimatorStateInfo(0);

            if ( infoB.IsName("happy") && infoB.normalizedTime >= 1.0f )
            {
                Idle();
                m_HappyCheck = false;
            }
        }

        if ( m_FunyCheck )
        {
            AnimatorStateInfo infoB = m_BodyAni.GetCurrentAnimatorStateInfo(0);

            if ( infoB.IsName("funy") && infoB.normalizedTime >= 1.0f )
            {
                Idle();
                m_FunyCheck = false;
            }
        }

        if ( m_LoverCheck )
        {
            AnimatorStateInfo infoB = m_BodyAni.GetCurrentAnimatorStateInfo(0);

            if ( infoB.IsName("lover") && infoB.normalizedTime >= 1.0f )
            {
                Idle();
                m_LoverCheck = false;
            }
        }

        if ( m_WinkCheck )
        {
            AnimatorStateInfo infoB = m_BodyAni.GetCurrentAnimatorStateInfo(0);

            if ( infoB.IsName("wink") && infoB.normalizedTime >= 1.0f )
            {
                Idle();
                m_WinkCheck = false;
            }
        }

        if ( m_WrongCheck )
        {
            AnimatorStateInfo infoB = m_BodyAni.GetCurrentAnimatorStateInfo(0);

            if ( infoB.IsName("wrong") && infoB.normalizedTime >= 1.0f )
            {
                Idle();
                m_WrongCheck = false;
            }
        }

        if ( m_SurpriseCheck )
        {
            AnimatorStateInfo infoB = m_BodyAni.GetCurrentAnimatorStateInfo(0);

            if ( infoB.IsName("surprise") && infoB.normalizedTime >= 1.0f )
            {
                Idle();
                m_SurpriseCheck = false;
            }
        }

        if ( m_ErrorCheck )
        {
            AnimatorStateInfo infoB = m_BodyAni.GetCurrentAnimatorStateInfo(0);

            if ( infoB.IsName("error") && infoB.normalizedTime >= 1.0f )
            {
                Idle();
                m_ErrorCheck = false;
            }
        }

    }

    public void Idle()
    {
        //body
        m_BodyAni.SetBool( "hi", false );
        m_BodyAni.SetBool( "think", false );
        m_BodyAni.SetBool( "happy", false );
        m_BodyAni.SetBool( "funy", false );
        m_BodyAni.SetBool( "lover", false );
        m_BodyAni.SetBool( "wink", false );
        m_BodyAni.SetBool( "wrong", false );
        m_BodyAni.SetBool( "tell", false );
        m_BodyAni.SetBool( "surprise", false );
        m_BodyAni.SetBool( "error", false );

        //face
        m_FaceAni.SetBool( "hi", false );
        m_FaceAni.SetBool( "think", false );
        m_FaceAni.SetBool( "happy", false );
        m_FaceAni.SetBool( "funy", false );
        m_FaceAni.SetBool( "lover", false );
        m_FaceAni.SetBool( "wink", false );
        m_FaceAni.SetBool( "wrong", false );
        m_FaceAni.SetBool( "tell", false );
        m_FaceAni.SetBool( "surprise", false );
        m_FaceAni.SetBool( "error", false );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[10];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[10];

        isThinking = false;
        m_Question.gameObject.SetActive(false);
        m_Surprise.gameObject.SetActive(false);

        //m_BodyAni.CrossFade("idle", 0.2f);
        //m_FaceAni.CrossFade("idle", 0.2f);
    }

    public void Hi()
    {
        // 카메라에 사람이 인식이 되었을 때 반응.
        Idle();

        m_BodyAni.SetBool( "hi", true );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[0] ;
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[0] ;
        m_FaceAni.SetBool( "hi", true );

        m_HiCheck = true;
    }

    public void Think()
    {
        Idle();

        m_BodyAni.SetBool( "think", true );

        m_Question.gameObject.SetActive( true );
        m_Question.speed = 1;
        m_Question.Play( "Question", 0, 0f );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[1];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[1];
        m_FaceAni.SetBool( "think", true );

        m_ThinkCheck = true;
    }

    public void Happy()
    {
        // "행복하세요", "좋은 날이네요" 같은 문구에 반응.
        Idle();

        m_BodyAni.SetBool( "happy", true );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[2];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[2] ;
        m_FaceAni.SetBool( "happy", true );

        m_HappyCheck = true;
    }

    public void Funy()
    {
        // 개그나 농담에 반응.
        Idle();

        m_BodyAni.SetBool( "funy", true );
        
        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[3];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[3] ;
        m_FaceAni.SetBool( "funy", true );

        m_FunyCheck = true;
    }

    public void Lover()
    {
        // "사랑한다"는 단어에 반응.
        Idle();

        m_BodyAni.SetBool( "lover", true );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[4];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[4] ;
        m_FaceAni.SetBool( "lover", true );

        m_LoverCheck = true;
    }

    public void Wink()
    {
        // 질문에 답일 때 반응 ex) 응 그게 맞아
        Idle();

        m_BodyAni.SetBool( "wink", true );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[5];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[5] ;
        m_FaceAni.SetBool( "wink", true );

        m_WinkCheck = true;
    }

    public void Wrong()
    {
        // 질문에 답이 아닐 때 반응 ex) 아니야
        Idle();

        m_BodyAni.SetBool( "wrong", true );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[6];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[6] ;
        m_FaceAni.SetBool( "wrong", true );

        m_WrongCheck = true;
    }

    public void Tell()
    {
        // 말을 할 때 반응.
        Idle();

        m_BodyAni.SetBool( "tell", true );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[7];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[7] ;
        m_FaceAni.SetBool( "tell", true );
    }

    public void Surprise()
    {
        // AI의 답이 틀렸을 때 반응.
        Idle();

        m_BodyAni.SetBool( "surprise", true );

        m_Surprise.gameObject.SetActive( true );
        m_Surprise.Play( "Surpise", 0, 0f );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[8];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[8] ;
        m_FaceAni.SetBool( "surprise", true );

        m_SurpriseCheck = true;
    }

    public void Error()
    {
        // 인식 오류일 때 반응.
        Idle();

        m_BodyAni.SetBool( "error", true );

        m_EyeRendererMaterial.sharedMesh = m_EyeMesh[9];
        m_MouseRendererMaterial.sharedMesh = m_MouseMesh[9] ;
        m_FaceAni.SetBool( "error", true );

        m_ErrorCheck = true;
    }
}
