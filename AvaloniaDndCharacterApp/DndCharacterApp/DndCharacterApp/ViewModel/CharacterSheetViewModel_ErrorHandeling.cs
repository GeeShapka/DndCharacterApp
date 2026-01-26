using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DndCharacterApp.ViewModel
{
    /*
	 * FILE : CharacterSheetViewModel_ErrorHandeling.cs
	 * PROJECT : $safeprojectname$
	 * PROGRAMMER : George Shapka
	 * FIRST VERSION : 1/26/2026 1:40:45 PM
	 */
    internal partial class CharacterSheetViewModel : ObservableObject, INotifyDataErrorInfo
    {
		private readonly Dictionary<string, List<string>> _errors = new Dictionary<string, List<string>>();

		public bool HasErrors
		{
			get { return _errors.Count > 0; }
        }

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

		public IEnumerable GetErrors(string? propertyName)
        {
			if(propertyName == null)
			{
				return Array.Empty<string>();
			}
			if(_errors.ContainsKey(propertyName))
			{
				return _errors[propertyName];
			}
			return Array.Empty<string>();
		}

		private void AddError(string propertyName, string error)
		{
			if(!_errors.ContainsKey(propertyName))
			{
				_errors[propertyName] = new List<string>();
			}
			if(!_errors[propertyName].Contains(error))
			{
				_errors[propertyName].Add(error);
				OnErrorsChanged(propertyName);
			}
		}

		private void ClearErrors(string propertyName)
		{
			if(_errors.ContainsKey(propertyName))
			{
				_errors.Remove(propertyName);
				OnErrorsChanged(propertyName);
			}
		}

        private void OnErrorsChanged(string propertyName)
		{
			ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
		}


    }//end of CharacterSheetViewModel_ErrorHandeling

}//end of DndCharacterApp.ViewModel