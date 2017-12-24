using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab5.Models.Helper
{
    public static class PhotoTableHelper
    {
        public static HtmlString GetPhotoTable()
        {
            using (var context = new DBModel.PhotoModel())
            {
                var photosession = context.photosession.Select(x => x);
                string table = @"<caption><h2>Прайс-лист</h2><hr></caption>
<tr><td>Вид съемки</td>
<td>Цена</td>
<td>Длительность съемки</td>
<td>Количество фото</td>
<td>Срок готовности фото</td></tr>";
                foreach (var item in photosession)
                {
                    table += $@"<tr><td>{(!string.IsNullOrEmpty(item.Type_photo) ? item.Type_photo: "-") }</td>
<td>{(item.Price != null ? item.Price.ToString() : "-") } руб.</td>
<td>{(!string.IsNullOrEmpty(item.Duration) ? item.Duration : "-") }</td>
<td>от {(item.Photo_amount != null ? item.Photo_amount.ToString() : "-") } шт.</td>
<td>{(!string.IsNullOrEmpty(item.Deadline) ? item.Deadline : "-") }</td></tr>";
                }
                return new HtmlString(table);
            }
        }
    }
}