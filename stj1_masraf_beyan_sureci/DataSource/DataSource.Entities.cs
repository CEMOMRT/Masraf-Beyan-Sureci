using System;
using System.Collections.Generic;
using System.Linq;
using Bimser.CSP.DataSource.Api.Models;
using Newtonsoft.Json;

namespace stj1_masraf_beyan_sureci.DataSources
{
   ///RequestEntities
  public class Flow1_ProcessItemsRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public List<object> Users { get; set; }

public List<object> Positions { get; set; }

public System.Int64 Skip { get; set; }

public System.Int64 Take { get; set; }

public System.String Culture { get; set; }

public System.Int64 ProcessType { get; set; }

public System.DateTime EndDate { get; set; }

public System.DateTime StartDate { get; set; }

public System.String FlowName { get; set; }

public System.String ProjectName { get; set; }

public System.Int64 RequestId { get; set; }
    }

public class Masraf_Odeme_AltAkis_ProcessItemsRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public List<object> Users { get; set; }

public List<object> Positions { get; set; }

public System.Int64 Skip { get; set; }

public System.Int64 Take { get; set; }

public System.String Culture { get; set; }

public System.Int64 ProcessType { get; set; }

public System.DateTime EndDate { get; set; }

public System.DateTime StartDate { get; set; }

public System.String FlowName { get; set; }

public System.String ProjectName { get; set; }

public System.Int64 RequestId { get; set; }
    }

public class tipiSorguRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        
    }

public class ikinciTipSorguRequest : BaseDataSourceDatabaseRequest
    {
        ///Properties
        public System.Int64 DGID { get; set; }
    }
}