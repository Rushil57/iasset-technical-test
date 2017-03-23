var weatherdata = {
    init: function () {
        $("#Country").on("blur", function () {
            if ($(this).val().trim() == '') {
                toastr.error('Please provide country name!');
                return false;
            }
            $("#dvWeatherConditions").hide();
            $.ajax({
                datatype: 'json',
                type: 'GET',
                cache: false,
                async: false,
                crossDomain: true,
                data: "country=" + $(this).val(),
                url: "http://localhost:63434/api/Home/GetCities",
                success: function (dataResponse) {
                    if (dataResponse.length > 0) {
                        $('#sltCity').empty();
                        $('#sltCity').append('<option>-- Select City --</option>');
                        for (var i = 0; i < dataResponse.length; i++) {
                            $("#sltCity").append('<option>' + dataResponse[i] + '</option>');
                        }
                        toastr.success('Cities populated successfully!');
                    }
                    else {
                        toastr.error('No cities found!');
                    }
                }

            })
        })
        $("#sltCity").on("change", function () {
            $("#dvWeatherConditions").show();
        })
    }

}
