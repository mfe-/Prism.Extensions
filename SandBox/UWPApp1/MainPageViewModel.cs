﻿using Model;
using Prism.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPApp1
{
    public class MainPageViewModel : ValidatableBindableBase
    {
        public MainPageViewModel()
        {
        }
        public ObservableCollection<Car> CarList { get; set; } = new ObservableCollection<Car>()
        {
            new Car() { Name = "a" },
            new Car() { Name = "ab" },
            new Car() { Name = "abc" },
            new Car() { Name = "abcd" },
        };

        private Car _SelectedCar;

        [Required]
        public Car SelectedCar
        {
            get { return _SelectedCar; }
            set { SetProperty(ref _SelectedCar, value); }
        }


    }
}
