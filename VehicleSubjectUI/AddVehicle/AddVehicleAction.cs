﻿using CoreGeneralization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSubjectUI.AddVehicle
{
    public class AddVehicleAction : IAction
    {
        private string Name { get; set; }
        public void Call()
        {
            AddVehicleForm addVehicleForm = new AddVehicleForm();
            addVehicleForm.Show();
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
