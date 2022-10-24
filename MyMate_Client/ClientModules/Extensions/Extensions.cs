using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientModules.Extensions
{
    public static class Extensions
    {

#pragma warning disable CS8714 // 형식은 제네릭 형식 또는 메서드에서 형식 매개 변수로 사용할 수 없습니다. 형식 인수의 Null 허용 여부가 'notnull' 제약 조건과 일치하지 않습니다.
        //ConcurrentDictionary의 AddOrUpdate 메서드의 확장
        //key, value를 입력했을 때 oldkey가 있다면 oldvalue의 값을 value로 대입해 갱신
        public static void AddOrUpdate<K, V>(this ConcurrentDictionary<K, V> dictionary, K key, V value)
        {
            dictionary.AddOrUpdate(key, value, (oldkey, oldvalue) => value);
        }
#pragma warning restore CS8714 // IDictionary의 key가 nullable이지만 송신 데이터는 모두 not null로 가정하므로 무시
    }
}
