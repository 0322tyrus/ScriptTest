using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//�N���X���L������G�Ȃǂ̖{�̘̂g�g�݁A�����o�֐��������̎��@�\�i�U���E�h��E�ړ��Ȃǁj�A�����o�ϐ�����̓I�Ȋe��̒l


public class Boss
{
    private int hp = 100;          // �̗�
    private int power = 25; // �U����
    private int mp = 53; //MP

    // �U���p�̊֐�
    public void Attack()
    {
        Debug.Log(this.power + "�̃_���[�W��^����");
    }

    //���@�U���p�̊֐�
    public void Magic(int Consume)
    {

            if (mp >= 5)
            {
                this.mp -= Consume;
                Debug.Log("���@�U���������B�c��MP��" + mp + "�B");
            }
            else
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B");
            }
        

    }

    // �h��p�̊֐�
    public void Defence(int damage)
    {
        Debug.Log(damage + "�̃_���[�W���󂯂�");
        // �c��hp�����炷
        this.hp -= damage;
    }

}
//�����܂łŃ{�X�̃f�[�^��U���h��ɂ��Ă̏������ł���


public class Test : MonoBehaviour
{

    void Start()
    {
        // Boss�N���X�̕ϐ���錾���ăC���X�^���X����
        Boss lastboss = new Boss();

        // �U���p�̊֐����Ăяo��
        lastboss.Attack();
        // �h��p�̊֐����Ăяo��
        lastboss.Defence(3);
        //���@�U���p�̊֐����Ăяo��
        for(int i = 0; i <= 10; i++)
        { 
             lastboss.Magic(5);
           
        }


        int[] array = new int[]{ 1, 2, 3, 4, 5 };

        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //�t���\�����@�@
        //�ϐ�t�̏����l��array.Length-1�ɂ���t=0�ɂȂ�܂ŌJ��Ԃ��A�T�ڂ̃f�[�^���珇�Ɏ擾
        for(int t = array.Length-1;t>=0; t--)
        {
            Debug.Log(array[t]);
        }

        //�t���\�����@�A�@Array.Reverse���g�p����炵���i7/24���s�A���݂��Ȃ��ƃG���[�Ɂc)
        //�i7/24�����@Using System; �������Ă����jC#�{���͎g���邪�Փ˂�����

        Array.Reverse(array);
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }



   /* // Use this for initialization
    void Start()
    {
        /*
        //�R���\�[����Hello, World�Ɠ���
        Debug.Log("Hello, World");

        //�ϐ��̐錾
        int score;

        //�ϐ��̑��
        score = 150;
        //�R���\�[���ɕϐ��̒��g��\��
        Debug.Log(score);

        //�ϐ�������������
        int a=3;
        int b=4;

        //�ϐ�a�ƕϐ�b�̍��v�l��ϐ�c�ɑ������
        int c=a+b;
        //�ϐ�c��\������
        Debug.Log(c);

        //money��200�ŏ���������
        int money=200;
        int money=50;

        if (money >= 100)
        {
            //money�̒l��100�ȏ�̏ꍇ�A�������\������
            Debug.Log("�|�[�V�����𔃂�");
        }


        //money��50�ŏ���������
        int money=50;
        int money=100;
        if (money >= 100)
        {
            //money��100�ȏゾ�����ꍇ
            Debug.Log("�|�[�V�����𔃂�")
        }
        else
        {
            //money��100�����������ꍇ
            Debug.Log("����𔄂�");
        }


        //money��100�ŏ���������
        int money = 100;
        
        if (money <= 50)
        {
            // money��50�ȉ��������ꍇ�̏���
            Debug.Log("����𔄂�");
        }
        else if (money >= 200)
        {
            // money��200�ȏゾ�����ꍇ�̏���
            Debug.Log("����𔃂�");
        }
        else
        {
            // ����ȊO�̏ꍇ�̏���
            Debug.Log("�|�[�V�����𔃂�");
        }


        // �O�����Z�q�c�l�����������ϐ�=(������)? �ϐ�1:�ϐ�2;
        
         // num��1�ŏ���������
        int num = 1;
        
        // val�ɑ������l�������ɂ���ĕς���(�O�����Z�q)
        int val = (num == 1) ? -100 : 100; �@�@num==1�Ȃ�val=-100�ɂȂ�Ƃ�������
       
        // val�̒l��\������
        Debug.Log(val);

        //�yif���g���Ă�������z

        int val;
        int num = 1;
        
        if(num == 1)
        {
            val = -100;
        }
        else
        {
            val = 100;
        }
        
        Debug.Log(val);


        //for���ɂ���
        
        // 5�񏈗����J��Ԃ�
                for (int i = 0; i < 5; i++)
                {
                        Debug.Log (i);
                }

        // 4�񏈗����J��Ԃ�
                for (int i = 0; i < 4; i++)
                {
                        Debug.Log (i);
                }

        //���v�l�����߂�

        // sum��0�ŏ���������
                int sum = 0;
                // 10�񏈗����J��Ԃ�
                for (int i = 1; i <= 10; i++)
                {
                        // i�̒l��sum�ɑ���
                        sum += i;
                }
                // sum�̒l��\������
                Debug.Log (sum);

         

        // �v�f��5�̔z�������������
        int[] points = new int[5];

        // �z��̊e�v�f�ɒl��������
        points[0] = 30;
        points[1] = 20;
        points[2] = 50;
        points[3] = 10;
        points[4] = 80;

        // �z��̗v�f�����ׂĕ\������
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };

        // �z��̗v�f���̂Ԃ񂾂��������J��Ԃ�
        for (int i = 0; i < points.Length; i++)
        {
            // �z��̗v�f��50�ȏ�̏ꍇ
            if (points[i] >= 50)
            {
                // �z��̗v�f��\������
                Debug.Log(points[i]);
            }
        }

        
         // �uHello�v�ɑ����Ĉ����̕������\������֐�
         void HelloName(string name)
         {
             Debug.Log("Hello, " + name);
         }

         void Start()
         {
             // HelloName�֐��ɁuUnity�v�Ƃ���������n��
             HelloName("Unity");
         }
        

        
        // �������Ƒ������̒l�𑫂����l��Ԃ��֐�
        int Add(int a, int b)
        {
            // �������Ƒ������̒l�𑫂��āA�ϐ�c�ɑ������
            int c = a + b;
            // �ϐ�c���Ăяo�����̊֐��ɕԂ�
            return c;
        }

        void Start()
        {
            // Add�֐��Ɂu3�v�Ɓu6�v�̈�����n���A�Ԃ�l��num�ϐ��ɑ������
            int num = Add(3, 6);
            // num��\������
            Debug.Log(num);
        }
        

    }*/
    


}
