(function ($) {
    ; $(function () {
        var dom = {
            queueList: ".queueList",
            fileList: '#filelist',
            fileItem: '.file-item',
            startUpload: '#ctlBtn'
        }, selt = 5;
        var fileNodes = $(dom.fileItem), selectClass = 'selected';
        $(dom.fileList).on('click', dom.fileItem, function (e) {
            var _this = $(this);
            var selected_count = $(dom.fileItem + '.selected').length;
            if (!_this.is('.' + selectClass)) {
                if (selected_count < selt)
                {
                    _this.addClass(selectClass);
                } else {
                    layer.msg('最多可以选择' + selt + '张');
                }
            } else {
                _this.removeClass(selectClass);
            }
        });
        $('.wu-example').on("mouseover mouseout", dom.fileItem, function (event) {
            if (event.type == "mouseover") {
                $(this).find('.toolbar').show();
            } else if (event.type == "mouseout") {
                $(this).find('.toolbar').hide();
            }
        });
        function sel(all) {
            fileNodes.each(function (i) {
                var item = $(this);
                if (all) {
                    item.addClass(selectClass);
                    //item.find('input').prop({ checked: true });
                } else {
                    item.removeClass(selectClass);
                    //item.find('input').prop({ checked: false });
                }
            });
        }
        $('#select_all').click(function () {
            var _this = $(this);
            if (!_this.data('all')) {
                sel(true);
                _this.text('取消全选');
                _this.data('all', true);
            } else {
                sel(false);
                _this.text('全选');
                _this.data('all', false);
            }
        });
        var options = {
            //swf文件路径
            swf: '/me/lib/script/webuploader/Uploader.swf',
            //文件接收服务端。
            server: 'upload.ashx',
            //选择文件的按钮。可选。内部根据当前运行是创建，可能是input元素，也可能是flash.
            pick: '#picker',
            //不压缩image, 默认如果是jpeg，文件上传前会压缩一把再上传！
            resize: false,
            dnd: 'body',
            disableGlobalDnd: true,
            paste: document.body,
            auto: true,
            //只允许选择图片文件。
            accept: {
                title: 'Images',
                mimeTypes: 'image/*'
            },
            formData: { group: $('#Id').val() }
        };
        var uploader = WebUploader.create(options), startUpload = $(dom.startUpload);
        startUpload.click(function () { uploader.upload(); });
        //文件被加入队列之前触发
        uploader.on('beforeFileQueued', function (file) {
            startUpload.fadeIn();
            $(dom.fileList).find('.empty').remove();
        });
        //当有文件被添加进队列的时候
        uploader.on('fileQueued', function (file) {
            uploader.makeThumb(file, function (error, src) {
                if (error) {
                    layer.msg('请选择图片');
                    return;
                }
                var item = $('<div class="file-item" id="' + file.id + '">' +
                    '<div class="thumbnail" >' +
                    '<div class="state-msg">等待上传...</div>' +
                    '<i class="img-thumb" style="background-image: url(' + src + ');"></i>' +
                    '<div class="caption">' +
                    '<p><a class="text-cut text-cut-full text-center" title="' + file.name + '">' + file.name + '</a></p>' +
                    '</div>' +
                    '<div class="schedule-box"><div class="progress no-radius">' +
                    '<div class="progress-bar progress-bar-info" role="progressbar" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100" style="width: 0%">' +
                    '<span class="sr-only">0%</span>' +
                    '</div></div></div>' +
                    '<div class="toolbar"><div class="btns"><span class="btn-group btn-group-justified btn-group-xs">' +
                    '<a class="dequeued btn btn-danger">取消上传</a>' +
                    '</span></div><div class="shade"></div></div>'+
                    '</div>' +
                    '</div>');
                $(dom.queueList).prepend(item);
                item.find('.dequeued').click(function () {
                    uploader.removeFile(file);
                    item.fadeOut().remove();
                });
            });
        });
        //文件上传过程中创建进度条实时显示。
        uploader.on('uploadProgress', function (file, percentage) {
            var fileitem = $('#' + file.id),
                $percent = fileitem.find('.progress-bar,.progress span');
            $percent.css('width', percentage * 100 + '%');
        });
        //文件上传成功
        uploader.on('uploadSuccess', function (file, response) {
            var fileitem = $('#' + file.id);
            if (response.state == 200) {
                var item = $('<div class="file-item" data-image="' + response.msg + '">' +
                    '<div class="thumbnail" >' +
                    '<i class="img-thumb" style="background-image: url(' + response.msg + ');"></i>' +
                    '<div class="caption">' +
                    '<p><a class="text-cut text-cut-full text-center" title="' + file.name + '">' + file.name + '</a></p>' +
                    '</div>' +
                    '</div>' +
                    '</div>');
                $(dom.fileList).prepend(item);
                $('#' + file.id).fadeOut().remove();
            }
        });
        //文件上传失败，显示上传出错。
        uploader.on('uploadError', function (file, reason) {
            //$('#' + file.id).find('.state').text('上传出错：【' + reason + '】');
            var toolbar = $('#' + file.id).find('.toolbar .btn-group');
            if (!toolbar.find('.retry').length)
            {
                toolbar.append('<a class="retry btn btn-default">重试上传</a>');
            }
            toolbar.on('click', '.retry', function () {
                uploader.retry(file);
            });
        });
        //完成上传完了，成功或者失败
        uploader.on('uploadComplete', function (file) {
            startUpload.hide();
        });
        //判断文件是否上传成功
        uploader.on('uploadAccept', function (obj, response) {
            var fileitem = $('#' + obj.file.id),
                state_box = fileitem.find('.state-msg');
            if (response.state != 200) {
                state_box.addClass('state-error');
                state_box.text('上传错误：' + response.msg);
                $('.dequeued').click(function () {
                    uploader.removeFile(obj.file, true);
                    $(this).parents('.file-item').fadeOut().remove();
                });
                return false;
            }
        });
        //查看队列
        $('#vQueue').click(function () {
            var obj = uploader.getStats();
            alert('队列中' + obj.queueNum + '个；上传成功' + obj.successNum + '个；上传中' + obj.progressNum + '个；上传失败' + obj.uploadFailNum + '个；无效的' + obj.invalidNum + '个');
        });
        //分组管理
        $('.group-edit').click(function () {
            var group_edit = $(this), swit = $('.material-group .item-edit');
            function switfun(s) {
                $('.material-group .item-edit').each(function () {
                    var material_group_item = $(this)
                    material_group_item.find('.block').each(function (i) {
                        if (i == s) {
                            material_group_item.find('.block').eq(i).show();
                        } else {
                            material_group_item.find('.block').eq(i).hide();
                        }
                    });
                });
            };
            switch (group_edit.data('state'))
            {
                case 0:
                    switfun(0)
                    group_edit.data('state', 1);
                    break;
                case 1:
                    switfun(1);
                    group_edit.data('state', 0);
                    break;
            }
        });
    });
})(jQuery);