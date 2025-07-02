using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Backend;
using WindowsFormsApp1.BL;

namespace WindowsFormsApp1.DL
{
    public class SemestersDL
    {
        static public void AddSemester(SemestersBL semester)
        {
            string dml = $"INSERT INTO semesters(semester_id, term, year) VALUES({semester.SemesterID}, '{semester.Term}', {semester.Year})";
            SqlHelper.executeDML(dml);
        }
        static public void AddSemesterWithoutID(SemestersBL semester)
        {
            string dml = $"INSERT INTO semesters(term, year) VALUES('{semester.Term}', {semester.Year})";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateSemester(SemestersBL semester)
        {
            string dml = $"UPDATE semesters SET term = '{semester.Term}', year = {semester.Year} WHERE semester_id = {semester.SemesterID}";
            SqlHelper.executeDML(dml);
        }

        static public void DeleteSemester(int semesterID)
        {
            string dml = $"DELETE FROM semesters WHERE semester_id = {semesterID}";
            SqlHelper.executeDML(dml);
        }

        public static List<SemestersBL> GetAll()
        {
            List<SemestersBL> listOfAllSemesters = new List<SemestersBL>();
            string query = "SELECT * FROM semesters";
            DataTable dtSemesters = SqlHelper.getDataTable(query);

            foreach (DataRow dr in dtSemesters.Rows)
            {
                string semesterID = dr["semester_id"].ToString();
                string term = dr["term"].ToString();
                string year = dr["year"].ToString();

                SemestersBL semester = new SemestersBL(int.Parse(semesterID), term, int.Parse(year));
                listOfAllSemesters.Add(semester);
            }
            return listOfAllSemesters;
        }
    }
}
