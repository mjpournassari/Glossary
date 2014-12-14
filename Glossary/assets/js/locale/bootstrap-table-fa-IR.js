/**
 * Bootstrap Table English translation
 * Author: Zhixin Wen<wenzhixin2010@gmail.com>
 */
(function ($) {
    'use strict';

    $.extend($.fn.bootstrapTable.defaults, {
        formatLoadingMessage: function () {
            return 'بارگیری اطلاعات';
        },
        formatRecordsPerPage: function (pageNumber) {
            return pageNumber + ' سطر در هر صفحه';
        },
        formatShowingRows: function (pageFrom, pageTo, totalRows) {
            return 'نمایش ' + pageFrom + ' تا ' + pageTo + ' از ' + totalRows + ' سطر';
        },
        formatSearch: function () {
            return 'جستجو';
        },
        formatNoMatches: function () {
            return 'موردی پیدا نشد';
        },
        formatRefresh: function () {
            return 'بارگیری مجدد';
        },
        formatToggle: function () {
            return 'Toggle';
        },
        formatColumns: function () {
            return 'ستون ها';
        }
    });
})(jQuery);