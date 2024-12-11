namespace Harmic.Models
{
    public class ViewModel
    {
        public List<TbAccount>? TbAccountList { get; set; }
        public List<TbBlog>? TbBlogList { get; set; }
        public List<TbBlogComment>? TbBlogCommentList { get; set; }
        public List<TbCategory>? TbCategoryList { get; set; }
        public List<TbContact>? TbContactList { get; set; }
        public List<TbCustomer>? TbCustomer { get; set; }
        public List<TbMenu>? TbMenuList { get; set; }
        public List<TbNews>? TbNews { get; set; }
        public List<TbOrder>? TbOrderList { get; set; }
        public List<TbOrderDetail>? TbOrderDetailList { get; set; }
        public List<TbOrderStatus>? TbOrderStatusList { get; set; }
        public List<TbProduct>? TbProductList { get; set; }
        public List<TbProductCategory>? TbProductCategoryList { get; set; }
        public List<TbProductReview>? TbProductReviewList { get; set; }
        public List<TbRole>? TbRoleList { get; set; }
        public TbProduct? SelectedProduct {get; set;}
        public TbBlog? SelectedTblog {get; set;}
    }
}
