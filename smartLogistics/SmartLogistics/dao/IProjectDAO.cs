/*
 * Created Date: 2022-07-19 (Tue)
 * Author: Doyun Jung (정도윤) / rabbit.white@daum.net
 * Subject: IProjectDAO
 * Filename: IProjectDAO.cs
 * Description:
 * 
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogistics.dao
{
    internal interface IProjectDAO
    {
        DataSet SelectAllProject();
        DataSet SelectKeywordProject(string keyword);

    }
}
