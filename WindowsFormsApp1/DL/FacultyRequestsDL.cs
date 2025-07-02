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
    public class FacultyRequestsDL
    {
        static public void AddFacultyRequest(FacultyRequestsBL facultyRequest)
        {
            string formattedDate = facultyRequest.RequestDate.ToString("yyyy-MM-dd HH:mm:ss");
            string dml = $"INSERT INTO faculty_requests(request_id, faculty_id, item_id, quantity, status_id, request_date) VALUES({facultyRequest.RequestID},{facultyRequest.FacultyID}, {facultyRequest.ItemID}, {facultyRequest.Quantity}, {facultyRequest.StatusID}, '{formattedDate}')";
            SqlHelper.executeDML(dml);
        }
        static public void AddFacultyRequestWithoutID(FacultyRequestsBL facultyRequest)
        {
            string formattedDate = facultyRequest.RequestDate.ToString("yyyy-MM-dd HH:mm:ss");
            string dml = $"INSERT INTO faculty_requests(faculty_id, item_id, quantity, status_id, request_date) VALUES({facultyRequest.FacultyID}, {facultyRequest.ItemID}, {facultyRequest.Quantity}, {facultyRequest.StatusID}, '{formattedDate}')";
            SqlHelper.executeDML(dml);
        }

        static public void UpdateFacultyRequest(FacultyRequestsBL facultyRequest)
        {
            string formattedDate = facultyRequest.RequestDate.ToString("yyyy-MM-dd HH:mm:ss");
            string dml = $"UPDATE faculty_requests SET faculty_id = {facultyRequest.FacultyID}, item_id = {facultyRequest.ItemID},quantity = {facultyRequest.Quantity}, status_id = {facultyRequest.StatusID}, request_date = '{formattedDate}' WHERE request_id = {facultyRequest.RequestID}";
            SqlHelper.executeDML(dml);
        }
        static public void UpdateFacultyRequestStatus(FacultyRequestsBL facultyRequest)
        {
            string dml = $"UPDATE faculty_requests SET status_id = {facultyRequest.StatusID} WHERE request_id = {facultyRequest.RequestID}";
            SqlHelper.executeDML(dml);
        }

        static public void DeleteFacultyRequest(int requestID)
        {
            string dml = $"DELETE FROM faculty_requests WHERE request_id = {requestID}";
            SqlHelper.executeDML(dml);
        }

        public static List<FacultyRequestsBL> GetAll()
        {
            List<FacultyRequestsBL> listOfAllFacultyRequests = new List<FacultyRequestsBL>();
            string query = "SELECT * FROM faculty_requests";
            DataTable dtFacultyRequests = SqlHelper.getDataTable(query);
            foreach (DataRow dr in dtFacultyRequests.Rows)
            {
                string requestID = dr["request_id"].ToString();
                string facultyID = dr["faculty_id"].ToString();
                string itemID = dr["item_id"].ToString();
                string quantity = dr["quantity"].ToString();
                string statusID = dr["status_id"].ToString();
                string requestDate = dr["request_date"].ToString();

                FacultyRequestsBL facultyRequest = new FacultyRequestsBL(
                    int.Parse(requestID), int.Parse(facultyID), int.Parse(itemID), int.Parse(quantity), int.Parse(statusID), DateTime.Parse(requestDate));

                listOfAllFacultyRequests.Add(facultyRequest);
            }
            return listOfAllFacultyRequests;
        }
        public static List<FacultyRequestsBL> GetApproved()
        {
            List<FacultyRequestsBL> listOfAllFacultyRequests = new List<FacultyRequestsBL>();
            string query = "SELECT * FROM faculty_requests WHERE status_id = 9 OR status_id = 10";
            DataTable dtFacultyRequests = SqlHelper.getDataTable(query);
            foreach (DataRow dr in dtFacultyRequests.Rows)
            {
                string requestID = dr["request_id"].ToString();
                string facultyID = dr["faculty_id"].ToString();
                string itemID = dr["item_id"].ToString();
                string quantity = dr["quantity"].ToString();
                string statusID = dr["status_id"].ToString();
                string requestDate = dr["request_date"].ToString();

                FacultyRequestsBL facultyRequest = new FacultyRequestsBL(
                    int.Parse(requestID), int.Parse(facultyID), int.Parse(itemID), int.Parse(quantity), int.Parse(statusID), DateTime.Parse(requestDate));

                listOfAllFacultyRequests.Add(facultyRequest);
            }
            return listOfAllFacultyRequests;
        }
        public static List<FacultyRequestsBL> GetApprovedByHead()
        {
            List<FacultyRequestsBL> listOfAllFacultyRequests = new List<FacultyRequestsBL>();
            string query = "SELECT * FROM faculty_requests WHERE status_id = 8";
            DataTable dtFacultyRequests = SqlHelper.getDataTable(query);
            foreach (DataRow dr in dtFacultyRequests.Rows)
            {
                string requestID = dr["request_id"].ToString();
                string facultyID = dr["faculty_id"].ToString();
                string itemID = dr["item_id"].ToString();
                string quantity = dr["quantity"].ToString();
                string statusID = dr["status_id"].ToString();
                string requestDate = dr["request_date"].ToString();

                FacultyRequestsBL facultyRequest = new FacultyRequestsBL(
                    int.Parse(requestID), int.Parse(facultyID), int.Parse(itemID), int.Parse(quantity), int.Parse(statusID), DateTime.Parse(requestDate));

                listOfAllFacultyRequests.Add(facultyRequest);
            }
            return listOfAllFacultyRequests;
        }
        static public DataTable GetDT()
        {

            string sql = "SELECT fr.request_id as RequestID , fr.faculty_id AS FacultyID, f.name AS FacultyName, f.designation_id as DesignationID, fr.item_id as ConsumableID, c.item_name as ItemName, fr.quantity as Quantity, fr.status_id as StatusID, fr.request_date as RequestDate FROM faculty_requests fr JOIN faculty f ON fr.faculty_id = f.faculty_id JOIN consumables c ON fr.item_id = c.consumable_id";
            DataTable dt = SqlHelper.getDataTable(sql);
            return dt;
        }
    }
}
