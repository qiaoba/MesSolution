using System;
using Component.Tools;
using System.Linq;
using System.Text;
using Core.Models;

namespace Core.Service
{

	public interface IRoute2OpService
	{
		 OperationResult AddEntity(Route2Op route2Op,bool isSave=true);
		 OperationResult DeleteEntity(string key,bool isSave=true);
		 OperationResult FindEntity(string key);
		 OperationResult UpdateEntity(Route2Op route2Op,bool isSave=true);
		 IQueryable<Route2Op>Route2Ops( );
	}
}
