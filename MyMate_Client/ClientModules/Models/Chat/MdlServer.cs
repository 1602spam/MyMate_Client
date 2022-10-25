using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientModules.Classes;

namespace ClientModules.Models.Chat
{
    public class MdlServer
    {
        //서버 코드
        public int? Code { get; set; }
        //단일 채팅방으로 표시할지 여부
        public bool IsCompact { get; set; }
        //타이틀
        public string Title { get; set; }
        //권한 코드 목록
        public List<int> PermissionCode { get; set; }
        //<권한 키, 유저코드>로 구성된 유저 목록
        public Dictionary<int, int> UserCodes { get; set; }
        //생성자 코드
        public int OwnerCode { get; set; }
    }
/*
객체를 죄다 받는지 선택해서 받는지 신경 쓰지 말고,
내가 필요로 하는 객체는 컨테이너에 있다고 보고,

상위 객체와 하위 객체간 관계는 다음과 같이 설정

상위 객체가 하위 객체 코드 리스트를 가지고 있고,
하위 객체는 알아서 잘 놀고 있고,

상위 객체를 표시할 때 하위 객체까지 같이 불러옴
하위 객체를 불러올 때 상위 객체의 리스트가 수정됨
*/
}
