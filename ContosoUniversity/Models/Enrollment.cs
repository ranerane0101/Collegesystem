using System;
namespace ContosoUniversity.Models
{
	public enum Grade
	{
		A,B,C,D,F
	}
	public class Enrollment
	{
		public int EnrollmentID { get; set; }
		//外部キー
		public int CourseID { get; set; }
		//外部キー
		public int StudentID { get; set; }

		public Grade? Grade { get; set; } = null!;

		//ナビゲーションプロパティ
		public Course Course { get; set; } = null!;
		//ナビゲーションプロパティ
		public Student Student { get; set; } = null!;
	}
}

