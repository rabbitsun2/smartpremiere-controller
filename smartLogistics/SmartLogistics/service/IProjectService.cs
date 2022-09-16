/*
 * Created Date: 2022-07-19 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: IProjectService
 * Filename: IProjectService.cs
 * Description:
 * 
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.service
{
    internal interface IProjectService
    {
        DataSet SelectAllProject();
        DataSet SelectKeywordProject(string keyword);


    }
}
