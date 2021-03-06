using System;
using Component.Tools;
using System.Linq;
using System.Text;
using Core.Models;

namespace Core.Service
{

	public interface ISimulationService
	{
		 OperationResult AddEntity(Simulation simulation,bool isSave=true);
		 OperationResult DeleteEntity(string key,bool isSave=true);
		 OperationResult FindEntity(string key);
		 OperationResult UpdateEntity(Simulation simulation,bool isSave=true);
		 IQueryable<Simulation>Simulations( );
	}
}
