using System;
using Component.Tools;
using System.Linq;
using System.Text;
using Core.Models;

namespace Core.Service
{

	public interface IErrorComService
	{
		 OperationResult AddEntity(ErrorCom tsErrorCause2Com,bool isSave=true);
		 OperationResult DeleteEntity(string key,bool isSave=true);
		 OperationResult FindEntity(string key);
		 OperationResult UpdateEntity(ErrorCom tsErrorCause2Com,bool isSave=true);
		 IQueryable<ErrorCom>TsErrorCause2Coms( );
	}
}
