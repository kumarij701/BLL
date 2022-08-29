using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BLL : DAL1
    {
        /**public int UserStoryId { get; set; }
        public int UserStoryName { get; set; }
        public int StoryOwner { get; set; }
        public int StoryPoints { get; set; }
        public int StoryDescription { get; set; }**/
        static void Main(string[] args)
        {
            DAL1 dal = new DAL1();
            dal.RetrieveData();


        }


    }
}
