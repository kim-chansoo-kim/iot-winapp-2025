﻿namespace SyntaxWinApp01
{
    /// <summary>
    /// Person 클래스
    /// </summary>
    internal class Person
    {
        // 기본 생성자
        public Person() { }

        public Person(string name, int age, char gender, string phone)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Phone = phone;
        }

        public string Name { get; set; } // getName, setName 을 다 자동 생성

        // Age가 int이기 때문에 -21억 ~ 21억
        // 그냥 값을 받고 사용할때는 public int Age { get; set; } 사용
        // 0~200사이만 들어가도록 변경
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                // value -> 특수 키워드
                if (value < 0 || value > 200)
                {
                    age = 20; // 잘못 넣으면 20고정
                }
                else
                {
                    age = value;
                }
            }
        }


        public char Gender { get; set; }
        public string Phone { get; set; }

        //  Python 클래스 __str__() 과 동일
        public override string ToString()
        {
            return $"Person 객체는\r\n이름, {Name}\r\n" + 
                $"나이, {Age}세\r\n성별, {Gender}\r\n" + 
                $"핸드폰, {Phone}";
        }

        public void Getup()
        {
            MessageBox.Show($"{Name}가 아침에 일어납니다.");
        }

        public void GoToSchool()
        {
            MessageBox.Show($"{Name}가 학교에 갑니다.");
        }

        // static : 컴파일 후 실행되면 메모리에 자리를 잡음
        // 객체를 생성하지 않고 바로 쓸 수 있음
        // static변수, 다른 static 메서드만 사용가능
        public static int GetNumber()
        {
            return 20;
        }
    }
}
