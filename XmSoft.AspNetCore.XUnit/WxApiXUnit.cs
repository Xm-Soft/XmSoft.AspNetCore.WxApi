using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XmSoft.AspNetCore.WxApi;
using XmSoft.AspNetCore.WxApi.Request.Card;
using XmSoft.AspNetCore.WxApi.Request;

namespace XmSoft.AspNetCore.XUnit
{
    public class WxApiXUnit
    {
        [Fact]
        public void Tests()
        {
            
            var s = 1;
            DateTime dt = DateTime.Now;
            var str = "121212";
            decimal d = 12;
            double d2 = 12.20;

            var s_name = s.GetType().Name;
            var dt_name = dt.GetType().Name;
            var d_name = d.GetType().Name;
            var str_name = str.GetType().Name;
            var d2_name = d2.GetType().Name;
            
        }

        [Fact]
        public void AccessToken()
        {
            using (var client = new WxApiClient())
            {
                var request = new WxApiGetAccessTokenRequest()
                {
                    AppId = "wx346f2583af4c5a8f",
                    Secret = "54421a46b51f40b0956b54a736421ea9"//
                };
                var s = client.ExecuteAsync(request);
                
            }
        }
        /// <summary>
        /// 创建卡券
        /// </summary>
        [Fact]
        public void CreateCard()
        {
            using (var client = new WxApiClient())
            {
                var request = new WxApiCreateCardRequest()
                {
                    AccessToken = "22_fOtMJTQ1LOpQWLcPYyTEfRzlX9lauaiXTA0_VGSJ_Got7ikCfbTpJO9S8y7sJWEJmTRiQWt2UzzzemkoFcpW5lMDOujE_cbkuFYjWCJ_ZTB9bZGKp26qmSmDeVkabaMGUxt9_F-b7ZKC_jaTCHGdACAJON",
                    groupon = new WxApi.Model.Card.CardGroupon
                    {
                        card_type = "GROUPON",
                        groupon = new WxApi.Model.Card.GrouponInfo
                        {
                            base_info = new WxApi.Model.Card.BaseInfo
                            {
                                logo_url = "http://mmbiz.qpic.cn/mmbiz/iaL1LJM1mF9aRKPZJkmG8xXhiaHqkKSVMMWeN3hLut7X7hicFNjakmxibMLGWpXrEXB33367o7zHN0CwngnQY7zb7g/0",
                                brand_name = "微信餐厅",
                                code_type = "CODE_TYPE_TEXT",
                                title = "132元双人火锅套餐",
                                color = "Color010",
                                notice = "使用时向服务员出示此券",
                                service_phone = "020-88888888",
                                description = "不可与其他优惠同享\n如需团购券发票，请在消费时向商户提出\n店内均可使用，仅限堂食",
                                date_info = new WxApi.Model.Card.Date_info
                                {
                                    type = "DATE_TYPE_FIX_TIME_RANGE",
                                    begin_timestamp = 1559722698,
                                    end_timestamp = 1562314684
                                },
                                sku = new WxApi.Model.Card.Sku
                                {
                                    quantity = 100000
                                },
                                use_limit = 100,
                                get_limit = 3,
                                use_custom_code = false,
                                bind_openid = false,
                                can_share = true,
                                can_give_friend = true,
                                location_id_list = new int[] {
                  123,
                  12321,
                  345345
                                },
                                center_title = "顶部居中按钮",
                                center_sub_title = "按钮下方的wording",
                                center_url = "www.qq.com",
                                custom_url_name = "立即使用",
                                custom_url = "http://www.qq.com",
                                custom_url_sub_title = "6个汉字tips",
                                promotion_url_name = "更多优惠",
                                promotion_url = "http://www.qq.com",
                                
                                //source = "大众点评"
                            },
                            advanced_info = new WxApi.Model.Card.AdvancedInfo
                            {
                                use_condition = new WxApi.Model.Card.use_condition
                                {
                                    accept_category = "鞋类",
                                    reject_category = "阿迪达斯",
                                    can_use_with_other_discount = true
                                },
                                _abstract = new WxApi.Model.Card.Abstract
                                {
                                    _abstract = "微信餐厅推出多种新季菜品，期待您的光临",
                                    icon_url_list = new string[] { "http://mmbiz.qpic.cn/mmbiz/p98FjXy8LacgHxp3sJ3vn97bGLz0ib0Sfz1bjiaoOYA027iasqSG0sjpiby4vce3AtaPu6cIhBHkt6IjlkY9YnDsfw/0"},
                                },
                                text_image_list = new List<WxApi.Model.Card.text_image_list>
                                {
                                    new WxApi.Model.Card.text_image_list
                                    {
                                        image_url = "http://mmbiz.qpic.cn/mmbiz/p98FjXy8LacgHxp3sJ3vn97bGLz0ib0Sfz1bjiaoOYA027iasqSG0sjpiby4vce3AtaPu6cIhBHkt6IjlkY9YnDsfw/0",
                                        text = "此菜品精选食材，以独特的烹饪方法，最大程度地刺激食 客的味蕾",
                                    },
                                    new WxApi.Model.Card.text_image_list
                                    {
                                        image_url = "http://mmbiz.qpic.cn/mmbiz/p98FjXy8LacgHxp3sJ3vn97bGLz0ib0Sfz1bjiaoOYA027iasqSG0sjpiby4vce3AtaPu6cIhBHkt6IjlkY9YnDsfw/0",
                                        text = "此菜品迎合大众口味，老少皆宜，营养均衡",
                                    }
                                },
                                time_limit = new List<WxApi.Model.Card.time_limit>
                                {
                                    new WxApi.Model.Card.time_limit
                                    {
                                        type = "MONDAY",
                       begin_hour=0,
                       end_hour=10,
                       begin_minute=10,
                       end_minute=59
                                    },
                                    new WxApi.Model.Card.time_limit
                                    {
                                        type = "HOLIDAY"
                                    }
                                },
                                business_service = new string[]
                                {
                                    "BIZ_SERVICE_FREE_WIFI",
                   "BIZ_SERVICE_WITH_PET",
                   "BIZ_SERVICE_FREE_PARK",
                   "BIZ_SERVICE_DELIVER"
                                }
                            },
                            deal_detail = "以下锅底2选1（有菌王锅、麻辣锅、大骨锅、番茄锅、清补 凉锅、酸菜鱼锅可选）：\n大锅1份 12元\n小锅2份 16元"
                        }
                    }
                };

                var result = client.ExecuteAsync(request);

                //Xunit.Assert.Equals("",result.)
            }
        }

        /// <summary>
        /// 创建二维码 卡券
        /// </summary>
        [Fact]
        public void CreateQRCodeCard()
        {
            using (var client = new WxApiClient())
            {
                var request = new WxApiCreateQRCodeByCardRequest
                {
                    AccessToken = "21_dJtsSPGDx3NsPrKdLPlR3WN_96Q2POj-y2mJKfMzhsDTZkQODyKQpOwI5SivfYJTy_xPFQrNoqh1Ic8lCsHssEOds4TU4PudnAlt54ipCsMYw-4rml7A5_TOxNoPopJePjSNx3KgRiR-4dhGYVIiABALIV",
                    Action_name = "QR_CARD",
                    Expire_seconds = 1800, 
                    Action_info = new WxApi.Model.Card.ActionInfo
                    {
                        card = new WxApi.Model.Card.CardInfo
                        {
                            card_id = "pyrsn1q0Oxn4bq4Fo_mC3F6mpZrM",//pyrsn1pIfrGgtugz3ch2Mo2yjpU0
                            code = "110201201245",
                            is_unique_code = false,
                            outer_str = "12b"
                        }
                    }
                };
                var result = client.ExecuteAsync(request);
            }
        }

        [Fact]
        public void CreateLandingPage()
        {
            using (var client = new WxApiClient())
            {
                var request = new WxApiCreateLandingPageRequest
                {
                    AccessToken = "22_lcPW7ejzZKvcSbhaySm1nNT7x8_kA1TohTpyY85fzYV1JfAvFxv_XGGwhg8YigSqfoT0RI6AAj2PDVgqFuvbYYi0BpWfN4zQ374ziMFxYqFrmvYdXpGq5zB-HSykdTlrOjj03sSsQkUcPx88HJOfAEABDI",
                   
                        banner = "http://test.ten10.com.cn/joycity/img/1-1.png",
                        title = "惠城优惠大派送",
                        can_share = false,
                        scene = "SCENE_NEAR_BY",
                        card_list = new List<CardList>
                    {
                        new CardList
                        {
                            card_id = "pyrsn1q0Oxn4bq4Fo_mC3F6mpZrM",
                            thumb_url = "http://test.ten10.com.cn/joycity/img/share.png"
                        }
                    }
                    
                };
                var result = client.ExecuteAsync(request);
            }
        }

       
    }

}
