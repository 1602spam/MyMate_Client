namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.calender1.Set(2022, 11);
			Calender.Schedule s = new("졸업작품", new(2022, 11, 16), new(2022, 11, 16));
			s.SetColor(Color.Aqua);
			calender1.Add(s);
			calender1.Add("Test Front", new(2022, 10, 30), new(2022, 11, 3));
			calender1.Add("Test", new(2022, 11, 2), new(2022, 11, 2));
			calender1.Add("Test", new(2022, 11, 2), new(2022, 11, 3));
			calender1.Add("졸업작품", new(2022, 11, 16), new(2022, 11, 16));
			calender1.Add("하나 더 추가", new(2022, 11, 16), new(2022, 11, 16));
			calender1.Add("큰거 하나 추가", new(2022, 11, 5), new(2022, 11, 10));
			calender1.Add("큰거", new(2022, 11, 20), new(2022, 11, 26));
			calender1.Add("큰거", new(2022, 11, 21), new(2022, 11, 24));
			calender1.Add("큰거", new(2022, 11, 20), new(2022, 11, 25));
			
			// 버그 상황
			calender1.Add("Test Front", new(2022, 10, 30), new(2022, 11, 3));
			calender1.Add("Test", new(2022, 11, 2), new(2022, 11, 3));
			calender1.Add("Test", new(2022, 11, 2), new(2022, 11, 2));
			calender1.Add("Test", new(2022, 11, 2), new(2022, 11, 3));

			calender1.Add("Test Front", new(2022, 11, 5), new(2022, 11, 9));
			calender1.Add("Test", new(2022, 11, 7), new(2022, 11, 8));
			calender1.Add("Test", new(2022, 11, 6), new(2022, 11, 7));
			calender1.Add("Test", new(2022, 11, 7), new(2022, 11, 8));
			calender1.Add("Test", new(2022, 11, 8), new(2022, 11, 8));
			calender1.Add("Test", new(2022, 11, 7), new(2022, 11, 8));

			s = new("아주큰거", new(2022, 11, 1), new(2022, 11, 30));
			s.SetColor(Color.Beige);
			calender1.Add(s);
			s = new("Test", new(2022, 11, 7), new(2022, 11, 7));
			s.SetColor(Color.Beige);
			calender1.Add(s);
			//calender1.SchduleReplace();


		}
	}
}