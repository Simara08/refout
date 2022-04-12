using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment {
    class NewGrup
    {
   
        public string No { get; set; }
        public string Category { get; set; }
        
        private bool _isonline;
        public bool IsOnline { get; set; }
        private int _limit;
        public int Limit
        {
            get
            {
                if (_isonline == true)
                {
                    return 15;
                }
                else
                {
                    return 10;
                }
            }
            set
            {
                value = _limit;
            }
        }
        public NewGrup(string no,string category,bool isonline)
        {
            No = no;
            Category = category;
            IsOnline = isonline;
        }
        
        
       

    }
}

//      private bool _isonline;
//public bool IsOnline

    //get
    //{
    //    if (_limit == 15 || _limit == 10)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}
    //set
    //{
    //    value = _isonline;
    //}


    

