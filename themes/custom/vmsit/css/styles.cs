@charset "UTF-8";
@font-face {
  font-family: Celias;
  src: url(fonts/Celias.woff2);
}
body {
  background-color: white;
  font-family: Celias, -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, Oxygen, Ubuntu, Cantarell, "Open Sans", "Helvetica Neue", sans-serif;
}

.commerce-product--full .offer-text {
  display: inline-block;
  background-color: #51AA1B;
  color: #fff;
  border: 1px solid #51AA1B;
  margin: 0px auto;
  padding: 4px 8px;
  text-align: center;
  font-size: 18px;
  font-weight: 580;
}
.commerce-product--full .product-name {
  font-size: 18px;
  font-weight: 580;
  color: #333333;
  margin: 4px 0px 4px 0px;
}
.commerce-product--full .product-mrp {
  color: #999999;
  font-size: 16px;
}
.commerce-product--full .product-mrp .product-old-price {
  display: inline;
  color: #666666;
  padding-left: 6px;
}
.commerce-product--full .product-mrp .product-old-price div {
  display: inline;
}
.commerce-product--full .selling-mrp {
  font-size: 16px;
  color: #333333;
}
.commerce-product--full .selling-mrp .product-price {
  display: inline;
  padding-left: 6px;
  font-size: 24px;
  font-weight: 580;
}
.commerce-product--full .selling-mrp .product-price div {
  display: inline;
}
.commerce-product--full .tax-text {
  font-size: 12px;
  color: #999999;
}
.commerce-product--full .available-variations .product--rendered-attribute label.option {
  border: 1px solid #333333;
  border-radius: 3px;
  padding: 8px 12px 8px 12px;
  margin: 12px 16px 12px 0;
  font-size: 16px;
}
.commerce-product--full .available-variations .product--rendered-attribute__selected ~ label.option {
  border: 1px solid #E96125;
  border-radius: 3px;
  color: #E96125;
  font-size: 16px;
}
.commerce-product--full .available-variations legend {
  margin: 0 auto;
  font-size: 14px;
  color: #666666;
}
.commerce-product--full .button--add-to-cart {
  background-color: #E96125;
  border: 1px solid #E96125;
  border-radius: 3px;
  color: #fff;
  font-size: 14px;
  text-align: center;
  padding: 12px 32px;
}
.commerce-product--full .product-detail .product-detail-title {
  color: #333333;
  font-size: 18px;
  font-weight: 580;
  padding: 16px 0 10px 0;
}
.commerce-product--full .product-detail .field__label {
  color: #333333;
  font-size: 14px;
  font-weight: 580;
}
.commerce-product--full .product-detail .field__item {
  color: #666666;
  font-size: 14px;
  font-weight: 200;
}
.commerce-product--full .product-detail .viewless, .commerce-product--full .product-detail .viewmore {
  color: #E96125;
  font-size: 16px;
  text-align: center;
}
.commerce-product--full .product-detail .viewless:hover, .commerce-product--full .product-detail .viewless:focus, .commerce-product--full .product-detail .viewmore:hover, .commerce-product--full .product-detail .viewmore:focus {
  color: #E96125;
}
.commerce-product--full .promise-title {
  font-size: 16px;
  font-weight: 580;
  color: #37A3BE;
}
.commerce-product--full .promise-title .promise-text {
  color: #333333;
  font-size: 14px;
}
.commerce-product--full .promise .promise-header {
  color: #333333;
  font-size: 18px;
  font-weight: 580;
}
.commerce-product--full .promise img {
  height: 34px;
  width: 34px;
}

.row-category-page {
  background-color: #fff;
  border-radius: 3px;
  border: 1px solid #eee;
  margin: 12px 6px 0;
}

.variation-block {
  margin: auto;
}
.variation-block:hover {
  border-right: 1px solid #eee;
  border-left: 1px solid #eee;
}
.variation-block .offer-price {
  display: inline-block;
  font-size: 14px;
  font-weight: 580;
  background-color: #51AA1B;
  color: white;
  z-index: 1;
  padding: 5px;
  border: 1px solid #51AA1B;
  border-radius: 3px;
  position: absolute;
  top: 10px;
  left: 10px;
}
.variation-block .product-variation-image img {
  height: 140px;
  width: 140px;
}
.variation-block .product-variation-image img:hover {
  transform: translateY(-3px);
  transition-duration: 0.4s;
  transition-property: -webkit-transform, transform;
}
.variation-block .product-variation-title {
  height: 38px;
  color: #666666;
  font-size: 16px;
}
.variation-block .product-variation-quantity {
  color: #999999;
  font-size: 14px;
  margin-top: 20px;
}
.variation-block .price-block {
  margin: 20px auto;
}
.variation-block .product-variation-price {
  font-size: 16px;
  font-weight: 580;
  color: #333333;
  margin: 0 auto;
}
.variation-block .product-variation-old-price {
  font-size: 14px;
  font-weight: 200;
  color: #999999;
  margin: 0 auto;
}
.variation-block .button--add-to-cart {
  color: #E96125;
  background-color: #fff;
  border: 1px solid #E96125;
  border-radius: 64px;
  font-size: 14px;
  text-align: center;
  padding: 10px 20px;
}
.variation-block .button--add-to-cart:hover {
  background-color: #E96125;
  color: #fff;
}

/*
@function slick-font-url($url) {
    @if function-exists(font-url) {
        @return font-url($url);
    }
    @else {
        @return url($slick-font-path + $url);
    }
}
*/
/* Slider */
.slick-loading .slick-list {
  background: #fff url("../vendor/slick/ajax-loader.gif") center center no-repeat;
}

@font-face {
  font-family: "FontAwesome";
  src: url(../vendor/font-awesome/fonts/fontawesome-webfont.woff2);
}
/* Icons 
@if $slick-font-family == "slick" {
    @font-face {
        font-family: "slick";
        src: slick-font-url("slick.eot");
        src: slick-font-url("slick.eot?#iefix") format("embedded-opentype"), slick-font-url("slick.woff") format("woff"), slick-font-url("slick.ttf") format("truetype"), slick-font-url("slick.svg#slick") format("svg");
        font-weight: normal;
        font-style: normal;
    }
}
*/
/* Arrows */
.slick-prev,
.slick-next {
  position: absolute;
  display: block;
  height: 28px;
  width: 28px;
  line-height: 0px;
  font-size: 1.5em;
  cursor: pointer;
  background: transparent;
  color: transparent;
  top: 50%;
  -webkit-transform: translate(0, -50%);
  -ms-transform: translate(0, -50%);
  transform: translate(0, -50%);
  padding: 0;
  border: none;
  outline: none;
}
.slick-prev:hover, .slick-prev:focus,
.slick-next:hover,
.slick-next:focus {
  outline: none;
  background: transparent;
  color: transparent;
}
.slick-prev:hover:before, .slick-prev:focus:before,
.slick-next:hover:before,
.slick-next:focus:before {
  opacity: 1;
}
.slick-prev.slick-disabled:before,
.slick-next.slick-disabled:before {
  opacity: 0.25;
}
.slick-prev:before,
.slick-next:before {
  font-family: "FontAwesome";
  font-size: 2em;
  line-height: 1;
  color: black;
  opacity: 0.75;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

.slick-prev {
  left: 10px;
  z-index: 1;
}
[dir=rtl] .slick-prev {
  left: 10px;
  z-index: 1;
}
.slick-prev:before {
  content: "";
}
[dir=rtl] .slick-prev:before {
  content: "";
}

.slick-next {
  right: 10px;
}
[dir=rtl] .slick-next {
  left: 10px;
  right: auto;
}
.slick-next:before {
  content: "";
}
[dir=rtl] .slick-next:before {
  content: "";
}

/* Dots */
.slick-dotted.slick-slider {
  margin-bottom: 30px;
}

.slick-dots {
  position: absolute;
  bottom: -25px;
  list-style: none;
  display: block;
  text-align: center;
  padding: 0;
  margin: 0;
  width: 100%;
}
.slick-dots li {
  position: relative;
  display: inline-block;
  height: 20px;
  width: 20px;
  margin: 0 5px;
  padding: 0;
  cursor: pointer;
}
.slick-dots li button {
  border: 0;
  background: transparent;
  display: block;
  height: 20px;
  width: 20px;
  outline: none;
  line-height: 0px;
  font-size: 0px;
  color: transparent;
  padding: 5px;
  cursor: pointer;
}
.slick-dots li button:hover, .slick-dots li button:focus {
  outline: none;
}
.slick-dots li button:before {
  position: absolute;
  top: 0;
  left: 0;
  content: "";
  width: 20px;
  height: 20px;
  font-family: "FontAwesome";
  font-size: 12px;
  line-height: 20px;
  text-align: center;
  color: #333333;
  opacity: 0.25;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
.slick-dots li.slick-active button:before {
  color: #E96125;
  opacity: 0.75;
}

/* Slider */
.slick-slider {
  position: relative;
  display: block;
  box-sizing: border-box;
  -webkit-touch-callout: none;
  -webkit-user-select: none;
  -khtml-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  -ms-touch-action: pan-y;
  touch-action: pan-y;
  -webkit-tap-highlight-color: transparent;
}

.slick-list {
  position: relative;
  overflow: hidden;
  display: block;
  margin: 0;
  padding: 0;
}
.slick-list:focus {
  outline: none;
}
.slick-list.dragging {
  cursor: pointer;
  cursor: hand;
}

.slick-slider .slick-track,
.slick-slider .slick-list {
  -webkit-transform: translate3d(0, 0, 0);
  -moz-transform: translate3d(0, 0, 0);
  -ms-transform: translate3d(0, 0, 0);
  -o-transform: translate3d(0, 0, 0);
  transform: translate3d(0, 0, 0);
}

.slick-track {
  position: relative;
  left: 0;
  top: 0;
  display: block;
  margin-left: auto;
  margin-right: auto;
}
.slick-track:before, .slick-track:after {
  content: "";
  display: table;
}
.slick-track:after {
  clear: both;
}
.slick-loading .slick-track {
  visibility: hidden;
}

.slick-slide {
  float: left;
  height: 100%;
  min-height: 1px;
  background-color: white;
  display: none;
}
[dir=rtl] .slick-slide {
  float: right;
}
.slick-slide img {
  display: block;
  margin: 0 auto;
  max-width: 100%;
  max-height: 400px;
}
.slick-slide.slick-loading img {
  display: none;
}
.slick-slide.dragging img {
  pointer-events: none;
}
.slick-initialized .slick-slide {
  display: block;
}
.slick-loading .slick-slide {
  visibility: hidden;
}
.slick-vertical .slick-slide {
  display: block;
  height: auto;
  border: 1px solid transparent;
}

.slick-arrow.slick-hidden {
  display: none;
}

/*# sourceMappingURL=styles.cs.map */
