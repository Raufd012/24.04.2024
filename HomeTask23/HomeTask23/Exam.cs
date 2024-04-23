using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask23
{
    internal class Exam
    {
		private string _subject;

		public string Subject
		{
			get { return _subject;

; }
			set { _subject = value; }
		}
		private int _examDuraction;

		public int ExamDuraction
		{
			get { return _examDuraction; }
			set { _examDuraction = value; }
		}

		public DateTime StartDate {  get; set; }
		public DateTime EndDate { get; set; }
		public Exam(string subject, int examduraxtion, DateTime start)
		{
			_subject = subject;
			_examDuraction = examduraxtion;
			StartDate = start;
			EndDate = start.AddMinutes(examduraxtion);
		}
	}
}
