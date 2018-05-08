function login() {
    $.ajax({
        //几个参数需要注意一下
        type: "POST",//方法类型
        dataType: "json",//预期服务器返回的数据类型
        url: "/Login/LoginAction",//url
        data: $('#Login_Form').serialize(),
        success: function (result) {
           
           
        },
        error: function () {
           
        }
    });
}