﻿function SinUp() {
    $.ajax({
        //几个参数需要注意一下
        type: "POST",//方法类型
        dataType: "json",//预期服务器返回的数据类型
        url: "/Login/SignUpAction",//url
        data: $('#Sigin_Form').serialize(),
        success: function (result) {
            if (result)
            {
                alert("成功");
                window.location.href = "/Login/LoginIndex";
                returns;
            }
            if (!result) {
                alert("注册失败");
                returns;
            }
        },
        error: function () {
            returns;

        }
    });
}

