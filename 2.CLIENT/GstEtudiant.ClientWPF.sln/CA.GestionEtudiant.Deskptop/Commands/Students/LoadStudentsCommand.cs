using CA.GestionEtudiant.Deskptop.Stores;
using CA.GestionEtudiant.Deskptop.Stores.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.GestionEtudiant.Deskptop.Commands.Students
{
    public class LoadStudentsCommand : AsyncCommandBase
    {
        //1- Properties  
        private readonly StudentStore studentStore;
        private readonly MessageStore _messageStore;

        //2- Constructor  
        public LoadStudentsCommand(StudentStore studentStore, MessageStore messageStore)
        {
            this.studentStore = studentStore;
            _messageStore = messageStore;
        }

        //3- Methods  
        protected override async Task ExecuteAsync(object parameter)
        {
            try
            {
                await studentStore.LoadStudentsAsync();
            }
            catch (Exception)
            {
                _messageStore.SetCurrentMessage("Failed to load students.", MessageType.Error);
            }
        }
    }
}
