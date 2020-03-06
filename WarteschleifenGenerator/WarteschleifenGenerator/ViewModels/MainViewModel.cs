using DelayLoop.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace WarteschleifenGenerator.VeiwModels
{
    class MainViewModel: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string UserInp_;
        public string UserInp
        {
            get
            {
                return UserInp_;
            }
            set
            {
                UserInp_ = value;
                NotifyPropertyChanged();
            }
        }

        public int Cycles_;
        public int Cycles
        {
            get
            {
                return Cycles_;
            }
            set
            {
                Cycles_ = value;
                NotifyPropertyChanged();
            }
        }
        public string _CyclesTextLabel { get; set; }
        public string CyclesTextLabel
        {
            get
            {
                return _CyclesTextLabel;
            }
            set
            {
                _CyclesTextLabel = value;
                NotifyPropertyChanged();
            }
        }
        public string _TimeRateText { get; set; }
        public string TimeRateText
        {
            get
            {
                return _TimeRateText;
            }
            set
            {
                _TimeRateText = value;
                NotifyPropertyChanged();
            }
        }
        public string _CyclesText { get; set; }
        public string CyclesText
        {
            get
            {
                return _CyclesText;
            }
            set
            {
                _CyclesText = value;
                NotifyPropertyChanged();
            }
        }
        public string _TimeText { get; set; }
        public string TimeText
        {
            get
            {
                return _TimeText;
            }
            set
            {
                _TimeText = value;
                NotifyPropertyChanged();
            }
        }
        public int _Time { get; set; }
        public int Time
        {
            get
            {
                return _Time;
            }
            set
            {
                _Time = value;
                NotifyPropertyChanged();
            }
        }
        public string _CycleRateText { get; set; }
        public string CycleRateText
        {
            get
            {
                return _CycleRateText;
            }
            set
            {
                _CycleRateText = value;
                NotifyPropertyChanged();
            }
        }
        public ParametrizeRelayCommand Lang { get; set; }
        public RelayCommand Go { get; set; }
        public RelayCommand _cyclesCheck { get; set; }
        public RelayCommand _timeCheck { get; set; }
        public string _GoTextLabel { get; set; }
        public string GoTextLabel
        {
            get
            {
                return _GoTextLabel;
            }
            set
            {
                _GoTextLabel = value;
                NotifyPropertyChanged();
            }
        }
        public MainViewModel()
        {
            Cycles = 24000000;
            Time = 6;
            UserInp = "User Input:";
            CyclesTextLabel = "1. Decide wether to input:";
            TimeRateText = "or time and cycle rate:";
            CyclesText = "Cycles";
            TimeText = "Time/sec";
            CycleRateText = "Cycle rate:";
            GoTextLabel = "Click on GO button";

            Lang = new ParametrizeRelayCommand(
                (param) =>
                {
                    if (param is string)
                    {
                        switch (param)
                        {
                            case "CZ":
                                Cycles = 24000000;
                                Time = 6;
                                UserInp = "Uživatelský vstup:";
                                CyclesTextLabel = "1. Chcete vložit:";
                                TimeRateText = "nebo čas a frekvenci:";
                                CyclesText = "Cykly";
                                TimeText = "Čas/sek";
                                CycleRateText = "Frekvence:";
                                GoTextLabel = "Klikni na GO tlačítko";
                                break;
                            case "EN":
                                Cycles = 24000000;
                                Time = 6;
                                UserInp = "User Input:";
                                CyclesTextLabel = "1. Decide wether to input:";
                                TimeRateText = "or time and cycle rate:";
                                CyclesText = "Cycles";
                                TimeText = "Time/sec";
                                CycleRateText = "Cycle rate:";
                                GoTextLabel = "Click on GO button";
                                break;
                        }
                    }
                },
                (param) => true
            );
        }
    }
}
