using System;

namespace GoodPrice.Data
{
    /// <summary>
    /// 商品
    /// </summary>
    public sealed class Good
    {
        /// <summary>
        /// 識別碼
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        public Nullable<Decimal> Price { get; set; }

        public Byte[] Image { get; set; }
    }
}
