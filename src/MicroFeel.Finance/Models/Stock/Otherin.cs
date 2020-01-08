using System;
using System.Collections.Generic;

namespace MicroFeel.Finance.Models
{
    /// <summary>
    /// 其他出库单
    /// </summary>
    public class Otherin
    {
        /// <summary>
        /// 单据编号
        /// </summary>
        public string Code { get; set; }
        ///<summary>
        ///制单日期
        ///</summary>
        public DateTime Date { get; set; }
        ///<summary>
        ///制单人名称
        ///</summary>
        public string Maker { get; set; }
        ///<summary>
        ///仓库编码
        ///</summary>
        public string Warehousecode { get; set; }
        ///<summary>
        ///仓库名称
        ///</summary>
        public string Warehousename { get; set; }
        ///<summary>
        ///备注
        ///</summary>
        public string Memory { get; set; }
        ///<summary>
        ///收发类型编码
        ///</summary>
        public string Receivecode { get; set; }
        ///<summary>
        ///收发类型
        ///</summary>
        public string Receivename { get; set; }
        ///<summary>
        ///部门编码
        ///</summary>
        public string Departmentcode { get; set; }
        ///<summary>
        ///部门名称
        ///</summary>
        public string Departmentname { get; set; }
        ///<summary>
        ///单据头自定义项1
        ///</summary>
        public string Define1 { get; set; }
        ///<summary>
        ///单据头自定义项2
        ///</summary>
        public string Define2 { get; set; }
        ///<summary>
        ///单据头自定义项3
        ///</summary>
        public string Define3 { get; set; }
        ///<summary>
        ///单据头自定义项4
        ///</summary>
        public DateTime Define4 { get; set; }
        ///<summary>
        ///单据头自定义项5
        ///</summary>
        public float Define5 { get; set; }
        ///<summary>
        ///单据头自定义项6
        ///</summary>
        public DateTime Define6 { get; set; }
        ///<summary>
        ///单据头自定义项7
        ///</summary>
        public float Define7 { get; set; }
        ///<summary>
        ///单据头自定义项8
        ///</summary>
        public string Define8 { get; set; }
        ///<summary>
        ///单据头自定义项9
        ///</summary>
        public string Define9 { get; set; }
        ///<summary>
        ///单据头自定义项10
        ///</summary>
        public string Define10 { get; set; }
        ///<summary>
        ///单据头自定义项11
        ///</summary>
        public string Define11 { get; set; }
        ///<summary>
        ///单据头自定义项12
        ///</summary>
        public string Define12 { get; set; }
        ///<summary>
        ///单据头自定义项13
        ///</summary>
        public string Define13 { get; set; }
        ///<summary>
        ///单据头自定义项14
        ///</summary>
        public string Define14 { get; set; }
        ///<summary>
        ///单据头自定义项15
        ///</summary>
        public float Define15 { get; set; }
        ///<summary>
        ///单据头自定义项16
        ///</summary>
        public float Define16 { get; set; }
        ///<summary>
        ///存货编码
        ///</summary>
        public IList<OtherinEntry> Otherinentry { get; set; }

    }

    /// <summary>
    /// 其他出库单明细
    /// </summary>
    public class OtherinEntry
    {

        ///<summary>
        ///存货编码
        ///</summary>
        public string Inventorycode { get; set; }

        ///<summary>
        ///存货
        ///</summary>
        public string Inventoryname { get; set; }

        ///<summary>
        ///规格型号
        ///</summary>
        public string Inventorystd { get; set; }

        ///<summary>
        ///数量
        ///</summary>
        public float Quantity { get; set; }

        ///<summary>
        ///单价
        ///</summary>
        public float Price { get; set; }

        ///<summary>
        ///金额
        ///</summary>
        public float Cost { get; set; }

        ///<summary>
        ///主计量单位名称
        ///</summary>
        public string Cmassunitname { get; set; }

        ///<summary>
        ///批号
        ///</summary>
        public string Serial { get; set; }

        ///<summary>
        ///生产日期
        ///</summary>
        public DateTime Makedate { get; set; }

        ///<summary>
        ///失效日期
        ///</summary>
        public DateTime Validdate { get; set; }

        ///<summary>
        ///自由项1
        ///</summary>
        public string Free1 { get; set; }

        ///<summary>
        ///自由项2
        ///</summary>
        public string Free2 { get; set; }

        ///<summary>
        ///自由项3
        ///</summary>
        public string Free3 { get; set; }

        ///<summary>
        ///自由项4
        ///</summary>
        public string Free4 { get; set; }

        ///<summary>
        ///自由项5
        ///</summary>
        public string Free5 { get; set; }

        ///<summary>
        ///自由项6
        ///</summary>
        public string Free6 { get; set; }

        ///<summary>
        ///自由项7
        ///</summary>
        public string Free7 { get; set; }

        ///<summary>
        ///自由项8
        ///</summary>
        public string Free8 { get; set; }

        ///<summary>
        ///自由项9
        ///</summary>
        public string Free9 { get; set; }

        ///<summary>
        ///自由项10
        ///</summary>
        public string Free10 { get; set; }

        ///<summary>
        ///单据体自定义项1
        ///</summary>
        public string Define22 { get; set; }

        ///<summary>
        ///单据体自定义项2
        ///</summary>
        public string Define23 { get; set; }

        ///<summary>
        ///单据体自定义项3
        ///</summary>
        public string Define24 { get; set; }

        ///<summary>
        ///单据体自定义项4
        ///</summary>
        public string Define25 { get; set; }

        ///<summary>
        ///单据体自定义项5
        ///</summary>
        public float Define26 { get; set; }

        ///<summary>
        ///单据体自定义项6
        ///</summary>
        public float Define27 { get; set; }

        ///<summary>
        ///单据体自定义项7
        ///</summary>
        public string Define28 { get; set; }

        ///<summary>
        ///单据体自定义项8
        ///</summary>
        public string Define29 { get; set; }

        ///<summary>
        ///单据体自定义项9
        ///</summary>
        public string Define30 { get; set; }

        ///<summary>
        ///单据体自定义项10
        ///</summary>
        public string Define31 { get; set; }

        ///<summary>
        ///单据体自定义项11
        ///</summary>
        public string Define32 { get; set; }

        ///<summary>
        ///单据体自定义项12
        ///</summary>
        public string Define33 { get; set; }

        ///<summary>
        ///单据体自定义项13
        ///</summary>
        public float Define34 { get; set; }

        ///<summary>
        ///单据体自定义项14
        ///</summary>
        public float Define35 { get; set; }

        ///<summary>
        ///单据体自定义项15
        ///</summary>
        public DateTime Define36 { get; set; }

        ///<summary>
        ///单据体自定义项16
        ///</summary>
        public DateTime Define37 { get; set; }

        ///<summary>
        ///行号
        ///</summary>
        public float Rowno { get; set; }

    }
}