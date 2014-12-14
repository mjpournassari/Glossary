/*

*/
// JavaScript Document
(function($) {
	$(document).ready(function() {

		$('#searchkey').each(function(){
			$(this).attr('title', $(this).val()).focus(function(){
				if ($(this).val() == $(this).attr('title')) {
				  $(this).val('');
				}
			}).blur(function(){
				if ($(this).val() == '' || $(this).val() == ' ') {
					$(this).val($(this).attr('title'));
				}
			});
		});

		$('input#searchkey').result(function(event, data, formatted) {
			$('#result').html(!data ? "No match!" : "Selected: " + formatted);
		}).blur(function(){		
		});
		
		$(function() {
			function format(item) {
				return '<a href="'+ item.permalink+'"><span class="title">' + item.title +'</span></a>';			
			}
			
			function link(item) {
				return item.permalink
			}

			function title(item) {
				return item.title
			}
		
			$("#searchkey").autocomplete(base + '?option=com_glossary&view=search', {
				width: $("#searchkey").outerWidth()-2,			
				max: 5,			
				scroll: false,
				dataType: "json",
				matchContains: "word",
				parse: function(data) {
					return $.map(data, function(row) {
						return {
							data: row,
							value: row.title,
							result: $("#searchkey").val()
						}
					});
				},
				formatItem: function(item) {				
					return format(item);
				}
			}).result(function(e, item) {
				$("#searchkey").val(title(item));
				//location.href = link(item);
			});						
		});
	});
})(jQuery);