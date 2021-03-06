﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace TaxiManager.Controller
{
    class CarBuildController : Model.CarBuildModel
    {
        
        public DataTable GetMakeType()
        {
            //TA.Fill(DT);
            DataTable DT;
            DT = GetCarMakes();
            return DT;
        }

        public DataTable GetMakeType(int RowIndex)
        {
            DataTable DT;
            DT = GetCarMakes(" WHERE cmid = " + RowIndex);
            return DT;
        }

        public DataTable GetMakeType(string WildCard)
        {
            DataTable DT;
            DT = GetCarMakes(WildCard);
            return DT;
        }

        public void InsertRow(string MakeName, int CreatedBy)
        {
            InsertCarMake(MakeName, CreatedBy);
        }

        public void UpdateRow(string MakeName, int UpdateBy, int RowIndex)
        {
            UpdateCarMake(MakeName, UpdateBy, RowIndex);
        }

        public void DeleteRow(int RowIndex)
        {
                DeleteCarMake(RowIndex, Classes.CConstant.LoginID);
        }
    }
}
