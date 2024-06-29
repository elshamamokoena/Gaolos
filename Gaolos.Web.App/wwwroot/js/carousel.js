carousel: function() {
    !function (e, t, r) {
        for (var o = 0; o < e.length; o++)
            t.call(r, o, e[o])
    }(document.querySelectorAll(".cz-carousel .cz-carousel-inner"), function (e, t) {
        var r, o = {
            container: t,
            controlsText: ['<i class="czi-arrow-left"></i>', '<i class="czi-arrow-right"></i>'],
            navPosition: "bottom",
            mouseDrag: !0,
            speed: 500,
            autoplayHoverPause: !0,
            autoplayButtonOutput: !1
        };
        null != t.dataset.carouselOptions && (r = JSON.parse(t.dataset.carouselOptions));
        var n = _objectSpread({}, o, {}, r);
        tns(n)
    })
}