/*
 * Created Date: 2022-07-19 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: ProjectService
 * Filename: ProjectService.cs
 * Description:
 * 
 */

using SmartLogistics.dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.service
{
    internal class ProjectService : IProjectService
    {
        IProjectDAO dao = new ProjectDAO();

        public DataSet SelectAllProject()
        {
            return dao.SelectAllProject();
        }

        public DataSet SelectKeywordProject(string keyword)
        {
            return dao.SelectKeywordProject(keyword);
        }

    }
}
