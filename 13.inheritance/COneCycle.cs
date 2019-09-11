using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _13.inheritance
{
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1;  // 바뀌
        public Rectangle _rtSquare1; //몸통
        private Color color; //Color는 System.Drawing에 struct로 정의 되어 있음

        public COneCycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3);  // Pen이라는 클래스의 생성자를 이용하여 (생성자에다가 Color.WhiteSmoke, 3 인자를 던져주어 _Pen 이라는 클래쓰 객체를 만들어라

            _rtCircle1 = new Rectangle(120, 150, 120, 120);  //Rectangle은 클래스이다    _rtCircle1 = new Rectangle(120, 150, 120, 120); 와 같은것 ==  Rectangle _rtCircle1 = new Rectangle(120, 150, 120, 120);
            _rtSquare1 = new Rectangle(150, 30, 60, 120);
        }

        public Pen fPeninfo()  //Pen 이라는 자료형을 리턴하는 함수
        {
            return _Pen;

        }
    }
}
