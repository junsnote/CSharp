/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ2
{
	class MainApp
	{
		class MyArray<T>
		{
			T[] m_arr;
			public MyArray(int size = 5)
			{
				m_arr = new T[size];
			}

			public T this[int index]
			{
				get { 
					return m_arr[index]; 
				}
				set { 
					if (index >= m_arr.Length){
						Array.Resize<T>(ref m_arr, index + 1);
					}
					m_arr[index] = value;
				}
			}
		}
		static void Main(string[] args)
		{
			// 일반화 클래스 MyArray의 객체를 생성한다. (객체 이름은 arr)
			// (자료형은 int, 생성자 함수 초기 값은 3)
			MyArray<int> arr = new MyArray<int>(3);
			arr[0] = 10;	// 배열 첫 번째 요소에 10을 치환
			arr[1] = 21;	// 배열 첫 번째 요소에 21을 치환
			arr[2] = 33;    // 배열 첫 번째 요소에 33을 치환

			Console.Write($"배열의 내용 : ");
			// 현재 배열을 출력한다. (인덱서 사용)
			for (int i = 0; i < 3; i++)
				Console.Write($"{arr[i]} ");
			Console.WriteLine();
		}
	}
}
*/