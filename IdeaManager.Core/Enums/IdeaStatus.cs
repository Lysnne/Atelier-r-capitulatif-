using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaManager.Core.Enums
{
    public enum IdeaStatus
    {
        Pending = 0,     // Idée soumise mais pas encore approuvée
        Approved = 1,    // Idée approuvée par un responsable
        Rejected = 2,    // Idée rejetée
        InProgress = 3,  // Idée en cours de transformation en projet
        Completed = 4    // Projet finalisé
    }
}
