namespace Domain
{
    public class Activity
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// 文章
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// 分類
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 場地
        /// </summary>
                                
        public string Venue { get; set; }
    }
}