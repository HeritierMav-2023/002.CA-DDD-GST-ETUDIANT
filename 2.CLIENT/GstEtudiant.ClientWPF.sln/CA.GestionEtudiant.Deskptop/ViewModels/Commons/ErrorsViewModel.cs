﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;


namespace CA.GestionEtudiant.Deskptop.ViewModels.Commons
{
    /// <summary>
    /// /// ViewModel that implements INotifyDataErrorInfo to provide validation errors for properties.
    /// </summary>
    public class ErrorsViewModel : ViewModelBase, INotifyDataErrorInfo
    {
        private readonly Dictionary<string, List<string>> _propertyErrors = new Dictionary<string, List<string>>();

        public bool HasErrors => _propertyErrors.Any();

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        public IEnumerable GetErrors(string? propertyName)
        {
            return _propertyErrors!.GetValueOrDefault(propertyName, null)!;
        }

        public void AddError(string propertyName, string errorMessage)
        {
            if (!_propertyErrors.ContainsKey(propertyName))
            {
                _propertyErrors.Add(propertyName, new List<string>());
            }

            _propertyErrors[propertyName].Add(errorMessage);
            OnErrorsChanged(propertyName);
        }

        public void ClearErrors(string propertyName)
        {
            if (_propertyErrors.Remove(propertyName))
            {
                OnErrorsChanged(propertyName);
            }
        }

        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }
    }
}
