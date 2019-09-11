using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.inheritance
{
    class CBase  //껍데기만 만드는 클래스
    {
        public string strName;
        protected Pen _Pen;  //protected는 상속을 하면 볼수 있다. 즉 COneCycle 클래쓰에서 사용가능 
        //private Pen _Pen;

        public CBase()
        {
          _Pen = new Pen(Color.Aqua); //펜에 대한 기본속성을 놓고 싶다면 여기 생성자에다가 (Pen = 자료형), Pen()는 System.Drawing에  있는 함수이다
            
        }
    }
}
