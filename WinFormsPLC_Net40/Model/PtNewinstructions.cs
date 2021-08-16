using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * @author : Derek_hu
 * @date : 2021-9-29
 * @desc : 新指令
 */
namespace WinFormsPLC_Net40.Model
{
   public class PtNewinstructions
    {
        /// <summary>
        /// id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string Itemcode { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Itemname { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string Creater { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime Createdate { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        public string Updateuser { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime Updatedate { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Isdetele { get; set; }

        /// <summary>
        /// 执行名称
        /// </summary>
        public string Performname { get; set; }

        /// <summary>
        /// 执行内容
        /// </summary>
        public string Performcontent { get; set; }

        /// <summary>
        /// 执行返回
        /// </summary>
        public string Performreturn { get; set; }
    }
}
