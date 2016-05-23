/**
 * Module for displaying "alert" dialog using Bootstrap
 *
 * @author Luciano Blanco <lucblanco@gmail.com>
 * 
 */

var alertDialog = alertDialog || (function ($) {
	'use strict';


	
	// Creating modal alert's DOM
	var $alert = $(
		'<div class="modal fade" data-backdrop="static" data-keyboard="false" tabindex="-1" role="dialog" aria-hidden="true" style="padding-top:15%; overflow-y:visible;">' +
				'<div class="modal-dialog modal-sm">'+
					'<div class="modal-content">'+
						'<div class="modal-header">'+
							'<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>'+
							'<h5 class="modal-title"></h5>'+
						'</div>'+
						'<div class="modal-body">'+
							'<span class="mesagem-box"></span>'+
						'</div>'+
						'<div class="modal-footer">'+														
						'</div>'+
					'</div>'+
				'</div>'+
			'</div>');

	var $okYes = $('<button id="btnOkYes" type="button" class="btn btn-danger" data-confirm-action="true" data-dismiss="modal" ></button>');
	var $cancelNo = $('<button id="btnCancelNo" type="button" class="btn btn-danger" data-confirm-action="false" data-dismiss="modal"></button>');
	return {
		/**
		 * Opens our dialog
		 * @param title Custom title for alert dialog
		 * @param message Custom message
		 * @param typeButton set the type of buttons alert show, e.g. "OkOnly", "OkCancel", "YesNo" 	
		 * @param options Custom options:
		 * 				  options.dialogSize - bootstrap postfix for dialog size, e.g. "sm", "m";
		 * 				  options.progressType - bootstrap postfix for progress bar type, e.g. "success", "warning".
		 */
		show: function (title, message, typeButton, options) {
			// Assigning defaults
			if (typeof options === 'undefined') {
				options = {};
			}
			if (typeof message === 'undefined') {
				message = 'sem mesagem';
			}
			if (typeof title === 'undefined') {
				title = 'Alert';
			}
			var settings = $.extend({
				dialogSize: 'sm',				
				onHide: null // This callback runs after the dialog was hidden
			}, options);

			// Configuring dialog
			$alert.find('.modal-dialog').attr('class', 'modal-dialog').addClass('modal-' + settings.dialogSize);
			//$alert.find('.progress-bar').attr('class', 'progress-bar');
			if (typeButton === "OkCancel") {
				$alert.find('.modal-footer').append($okYes);
				$alert.find('#btnOkYes').text('Ok');
				
				$alert.find('.modal-footer').append($cancelNo);
				$alert.find('#btnCancelNo').text('Cancelar');
			}
			else if (typeButton === "YesNo") {
			    $alert.find('.modal-footer').append($okYes);
			    $alert.find('#btnOkYes').text('Sim');

			    $alert.find('.modal-footer').append($cancelNo);
			    $alert.find('#btnCancelNo').text('Não');
			}
			//case OkOnly is default value button
			else {			    
				$alert.find('.modal-footer').append($okYes);
				$alert.find('#btnOkYes').text('Ok');
			}
			$alert.find('h5').text(title);
			$alert.find('.mesagem-box').text(message);			

			// Adding callbacks
			if (typeof settings.onHide === 'function') {
				$alert.off('hidden.bs.modal').on('hidden.bs.modal', function (e) {
					settings.onHide.call($alert);
				});
			}
			// Opening dialog
			$alert.modal();
		},
		/**
		 * Closes dialog
		 */
		hide: function () {
			$alert.modal('hide');
		}
	};

})(jQuery);