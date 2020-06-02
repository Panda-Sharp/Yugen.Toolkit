﻿using System;
using System.Windows.Input;

namespace Yugen.Toolkit.Standard.Mvvm.Input
{
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute = null;
        private readonly bool _canExecute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<T> execute, bool canExecute = true)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => _canExecute;

        public void Execute(object parameter) => _execute?.Invoke((T)parameter);
    }
}