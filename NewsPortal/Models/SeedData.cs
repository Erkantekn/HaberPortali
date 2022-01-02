using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace NewsPortal.Models
{

    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            PortalDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<PortalDbContext>();
            context.Database.EnsureCreated();//Bu olmadan program hata verir
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Magazin",
                        Color = "purple"
                    },
                       new Category
                       {
                           Name = "Seyahat",
                           Color = "green"
                       },
                          new Category
                          {
                              Name = "Sanat",
                              Color = "blue"
                          }, new Category
                          {
                              Name = "İş",
                              Color = "#637e7e"
                          }, new Category
                          {
                              Name = "Politika",
                              Color = "red"
                          }, new Category
                          {
                              Name = "Spor",
                              Color = "orange"
                          }

                    );
                context.SaveChanges();
            }

            if (!context.News.Any())
            {
                context.News.AddRange(
                        new News
                        {
                            Topic = "2021 Yazının En Gözde Makyaj Trendleri ve Malzemeleri",
                            Content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            ImagePath = "images/news/default-1.png",
                            PublishDate = DateTime.Now,
                            Category = context.Categories.FirstOrDefault(x => x.Name == "Magazin")
                        },
                      new News
                      {
                          Topic = "Bisiklet kazalarına kayıtsız kalmadı, sinyal veren kask icat etti",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam ac odio vitae dolor sollicitudin pretium. Quisque maximus condimentum tellus sit amet pulvinar. Maecenas gravida bibendum nibh, id feugiat tortor mollis eget. Etiam faucibus leo vel vestibulum malesuada. Sed viverra nulla nec placerat feugiat. Sed vehicula, magna eget sodales efficitur, nisl velit maximus arcu, bibendum iaculis libero leo eu tellus. In vitae efficitur mauris. Sed non orci sit amet ex vulputate ullamcorper. Duis aliquam vel risus eget tristique. Nullam porta dapibus elit. Sed ut consequat elit, in pulvinar elit.",
                          ImagePath = "images/news/default-2.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name == "Spor")
                      }, new News
                      {
                          Topic = "Havada panik anları! Rota değiştirip acil iniş yaptı.",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque cursus maximus justo tristique gravida. Nullam purus ligula, ornare vel massa non, varius tristique libero. Sed ultricies bibendum volutpat. Etiam at mattis quam. Pellentesque diam risus, rutrum malesuada tempus ullamcorper, tincidunt non tellus. Maecenas vehicula rutrum ipsum vel fermentum. Nam aliquet laoreet felis, at porttitor leo vestibulum sed. Phasellus scelerisque venenatis feugiat. Aenean semper eros dignissim tortor suscipit tincidunt. Mauris quam lectus, pulvinar porttitor enim sed, pulvinar porttitor urna. Nam interdum elit eu mattis rutrum. Praesent ac rutrum enim. Aenean posuere urna at arcu viverra ultrices. Etiam lacinia tempus euismod.",
                          ImagePath = "images/news/default-3.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name == "Seyahat")
                      }, new News
                      {
                          Topic = "Savaşın bitiminin 100. yılında kızıl gelincik kavgası",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque luctus nunc ut congue vulputate. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. In quis vehicula nunc. Ut tempor dui orci, ac auctor felis consequat et. Aliquam erat volutpat. Cras rhoncus varius ipsum, id fringilla nisl porta sed. Etiam malesuada convallis tortor id fermentum. Sed vitae tellus pharetra, tincidunt nulla ac, fermentum enim. Nullam eget tincidunt purus. Vivamus sollicitudin ultrices lectus, a aliquam ex tempor eu. Mauris convallis, dolor fermentum tempus facilisis, lacus enim condimentum urna, nec pellentesque eros metus et magna. In egestas eu nisl non egestas.",
                          ImagePath = "images/news/default-4.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name=="Politika")
                      }, new News
                      {
                          Topic = "Dünyanın umudu 'Aşı'nın kitabı çıktı... Onlara kimse inanmamış!",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla dapibus massa ut felis volutpat accumsan. Nam non dignissim mi. Etiam hendrerit pretium erat eget vulputate. Nam et justo rutrum, condimentum augue tempor, commodo ex. Cras a eros sagittis, condimentum mi ultricies, gravida sapien. Ut volutpat nibh quis venenatis rutrum. Sed quis erat at diam viverra pharetra.",
                          ImagePath = "images/news/default-7.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name == "Sanat")
                      }, new News
                      {
                          Topic = "Güzellik Standartlarını Yenileyen Kadınlar",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut malesuada risus blandit dapibus malesuada. Vivamus lacus libero, dapibus ut lobortis ut, tristique in ante. Fusce tristique mollis iaculis. Aenean id erat est. Fusce congue ipsum vel magna feugiat dignissim eu sit amet ex. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Vestibulum egestas gravida augue, vitae vulputate odio dapibus quis. Nulla suscipit eros nec ex mollis, ac luctus nisi rhoncus.",
                          ImagePath = "images/news/default-5.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name == "Magazin")
                      }, new News
                      {
                          Topic = "İnşaat malzemesi sektöründe 2021’de yüzde 6-7 büyüme bekleniyor.",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur rhoncus tincidunt purus, quis congue nibh ultricies et. Proin posuere a ipsum quis mattis. Donec vitae auctor ligula. Suspendisse pretium diam velit, a accumsan libero pretium vitae. Nunc consectetur, felis sagittis ultrices imperdiet, lectus urna vestibulum eros, vitae pharetra dui tortor et enim. Praesent facilisis maximus tellus, vel rutrum odio luctus sed. Pellentesque imperdiet in nisl vel malesuada. Praesent a diam leo. Cras sed tempor ipsum. Curabitur blandit, est non iaculis interdum, nisl massa tristique elit, vel aliquet magna lectus vitae elit. Fusce hendrerit lacus turpis, sit amet tincidunt elit finibus sit amet. Suspendisse placerat nunc eu mauris eleifend, ut porttitor ipsum hendrerit. Vivamus ac quam mattis, aliquam est a, molestie diam. Aenean bibendum orci sit amet leo placerat, et venenatis ex sodales. Vivamus fringilla ut eros mollis malesuada.",
                          ImagePath = "images/news/default-9.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name == "İş")
                      }, new News
                      {
                          Topic = "Abant’a tatilci akını",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris id magna vestibulum, vehicula est eu, tincidunt nunc. Maecenas condimentum rhoncus lacus in facilisis. Suspendisse potenti. Mauris libero justo, venenatis varius felis ut, facilisis volutpat erat. Proin sodales, lectus eu iaculis congue, tortor metus mattis mi, vitae ultricies nisl quam in odio. Praesent quis luctus ligula. Mauris hendrerit sodales facilisis. Sed et finibus ante, ac pellentesque eros.",
                          ImagePath = "images/news/default-6.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name == "Seyahat")
                      }, new News
                      {
                          Topic = "Sonbaharın son etkinlikleri",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut viverra felis et nisl iaculis bibendum. Phasellus aliquam aliquet libero, nec tincidunt ligula efficitur sit amet. Sed rhoncus diam quis massa condimentum, sed sollicitudin quam tincidunt. Donec est dui, hendrerit tristique luctus ac, tincidunt volutpat sapien. Pellentesque suscipit, leo in eleifend condimentum, justo arcu interdum augue, ut faucibus turpis tellus non quam. Nulla maximus nunc non finibus cursus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Proin fringilla condimentum felis in pellentesque. Mauris semper risus volutpat dapibus dignissim. Curabitur ut metus in massa vestibulum vestibulum vitae eu quam. Praesent placerat enim venenatis purus suscipit fringilla. Phasellus at semper urna. Pellentesque in lobortis nulla, non scelerisque quam.",
                          ImagePath = "images/news/default-8.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name == "Sanat")
                      }, new News
                      {
                          Topic = "İşportada satılan gözlüklere dikkat",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut dictum dolor et lorem pretium, a sollicitudin dolor facilisis. Nullam rutrum egestas pellentesque. Nunc faucibus turpis ac metus interdum, at condimentum lacus blandit. In mauris risus, placerat in erat eget, tristique rutrum nisi. Phasellus nec pulvinar diam. Nunc molestie magna ac nisi porta, lobortis vehicula magna malesuada. Integer gravida magna et lectus tristique, quis blandit velit porta. Praesent at volutpat lorem, ultricies scelerisque nisl. Phasellus non efficitur mi. Curabitur a neque sed lorem tincidunt tincidunt sed ut risus.",
                          ImagePath = "images/news/default-11.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name == "Magazin")
                      }, new News
                      {
                          Topic = "İstanbul'da mesai saatlerine güncelleme.. İşte uygulanacak yeni mesai saatleri.",
                          Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus sed sodales mi. Phasellus a mauris lacus. Nullam ac justo in ante blandit dignissim. Proin massa erat, fringilla quis metus at, semper egestas velit. Morbi orci ligula, vestibulum et libero a, lacinia molestie diam. Nam porta finibus euismod. Nam aliquet ex ac leo aliquet volutpat. Maecenas dapibus lorem quis lorem accumsan, eu rhoncus arcu laoreet. Duis nunc ligula, gravida in congue nec, faucibus sed risus.",
                          ImagePath = "images/news/default-10.png",
                          PublishDate = DateTime.Now,
                          Category = context.Categories.FirstOrDefault(x => x.Name == "İş")
                      }
                ) ;
                context.SaveChanges();
            }

         
        }
    }
}
