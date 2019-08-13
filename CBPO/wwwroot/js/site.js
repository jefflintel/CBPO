$(function () {

    $(".youth-button").on("click", showYouthDemographics);
    $(".adult-button").on("click", showAdultDemographics);
    $(".basic-clear-button").on("click", resetBasicDemographics);
    $(".submit-button").on("click", submitDemographics);
    $(".zip-code-button").on("click", showLocationData);
    $(".income-button").on("click", showIncomeData);
    $(".age-button").on("click", showAgeData);
    
    function showYouthDemographics() {
        if ($(".adult-demographics").hasClass("hidden")) {

            $(".youth-demographics").removeClass("hidden");
            console.log("youth button test");
            $(".adult-button").addClass("hidden");
            $(this).addClass("hidden");
            $(".basic-clear-button").removeClass("hidden");
            $(".submit-clear-buttons").removeClass("hidden");
        }        
    }

    function showAdultDemographics() {
        if ($(".youth-demographics").hasClass("hidden")) {
            $(".adult-demographics").removeClass("hidden");
            console.log("adult button test");
            $(".youth-button").addClass("hidden");
            $(this).addClass("hidden");
            $(".basic-clear-button").removeClass("hidden");
            $(".submit-clear-buttons").removeClass("hidden");
        }
    }

    function getLocationData() {
        $.ajax({
            url: "demographics/location",
            dataType: "json",

        })
    }

    function showLocationData() {
        
    }

    function getIncomeData() {
        $.ajax({
            url: "demographics/income",
            dataType: "json",

    }

    function showIncomeData() {

    }

    function getAgeData() {
        $.ajax({
            url: "demographics/income",
            dataType: "json",
    }

    function showAgeData() {

    }

    function submitDemographics() {
        $.ajax({
            url: "demographics/new",
            method: "post",
            dataType: "json",
            data: {
                firstName: $("#first-name").val(),
                lastName: $("#last-name").val(),
                streetAddress: $("#street-address").val(),
                city: $("#city").val(),
                state: $("#state").val(),
                zip: $("#zip").val(),
                dateOfBirth: $("#dob").val()
            },
            error: "Ajax Error",
            success: "Success"
        })
        $(".basic-demographics").addClass("hidden");
        $(".youth-demographics").addClass("hidden");
        $(".adult-demographics").addClass("hidden");
        $(".submit-clear-buttons").addClass("hidden");
        $(".checklist").removeClass("hidden");
    }

    function newChecklist() {
        $.ajax({
            url: "checklist/new",
            method: "post",
            dataType: "json",
            data: {

                serialNumber: $("#bike-serial-number").val(),
                brand: $("#bike-brand").val(),
                model: $("#bike-model").val(),
                color: $("#bike-color").val()

            },
            error: "Ajax Error",
            success: "Success"

        })
    }

    function updateChecklist() {
        $.ajax({
            url: "checklist/update",
            method: "post",
            dataType: "json",
            data: {
                cleanInspectForCracks: $.attr("clean-inspect").val(),
                greaseSeatpost: $.attr("grease-seatpost").val(),
                inspectForCracksBends: $.attr("inspect-cracks-bends").val(),
                greaseStem: $.attr("grease-stem"),
                repackBottomBracket: $.attr("repack-bottom-bracket").val(),
                greasePedalThreads: $.attr("grease-pedal-threads").val,
                cableAdjustFrontDer: $.attr("cable-adjust-front-derailleur"),
                cableAdjustRearDer: $.attr("cable-adjust-rear-derailleur"),
                checkChainStretch: $.attr("check-chain-stretch"),
                cleanOilChain: $.attr("clean-oil-change").val(),
                cableAdjustFrontBrake: $.attr("cable-adjust-front-brake").val(),
                cableAdjustRearBrake: $.attr("cable-adjust-rear-brake").val(),
                repackFrontHub: $.attr("repack-front-hub").val(),
                trueFrontWheel: $.attr("true-front-wheel").val(),
                repackRearHub: $.attr("repack-rear-hub").val(),
                trueRearWheel: $.attr("true-rear-wheel").val(),
                inflateTires: $.attr("inflate-to-proper-pressure").val(),
                tireHoldingAir: $.attr("tires-holding-air").val(),
                accurateShifting: $.attr("accurate-shifting").val(),
                goodBraking: $.attr("good-braking-power").val(),
                ridingClassCompleted: $.attr("riding-class-completed").val()
            },
            error: "Ajax Error",
            success: "Success"
        })
    }

    function resetBasicDemographics() {
        $(this).toggleClass("hidden");
        $(".youth-demographics").addClass("hidden");
        $(".adult-demographics").addClass("hidden");
        $(".youth-button").removeClass("hidden");
        $(".adult-button").removeClass("hidden");
        $("#first-name").val("First Name");
        $("#last-name").val("Last Name");
        $("#street-address").val("Street Address")
        $("#city").val("City");
        $("#state").val("State");
        $("#zip").val("Zip");
    }
    /*
    function submitDemographics() {

        let data = {
            firstName = $("#first-name").val(),
            lastName = $("#last-name").val(),
            streetAddress = $("#street-address").val(),
            city = $("#city").val(),
            state = $("#state").val(),
            zip = $("#zip").val()
        }
    }*/

});
