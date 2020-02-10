function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function _defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } }

function _createClass(Constructor, protoProps, staticProps) { if (protoProps) _defineProperties(Constructor.prototype, protoProps); if (staticProps) _defineProperties(Constructor, staticProps); return Constructor; }

(window["webpackJsonp"] = window["webpackJsonp"] || []).push([["components-product-management-product-management-module"], {
  /***/
  "./src/app/components/product-management/product-management.component.ts":
  /*!*******************************************************************************!*\
    !*** ./src/app/components/product-management/product-management.component.ts ***!
    \*******************************************************************************/

  /*! exports provided: ProductManagementComponent */

  /***/
  function srcAppComponentsProductManagementProductManagementComponentTs(module, __webpack_exports__, __webpack_require__) {
    "use strict";

    __webpack_require__.r(__webpack_exports__);
    /* harmony export (binding) */


    __webpack_require__.d(__webpack_exports__, "ProductManagementComponent", function () {
      return ProductManagementComponent;
    });
    /* harmony import */


    var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
    /*! @angular/core */
    "./node_modules/@angular/core/__ivy_ngcc__/fesm2015/core.js");

    var ProductManagementComponent =
    /*#__PURE__*/
    function () {
      function ProductManagementComponent() {
        _classCallCheck(this, ProductManagementComponent);
      }

      _createClass(ProductManagementComponent, [{
        key: "ngOnInit",
        value: function ngOnInit() {}
      }]);

      return ProductManagementComponent;
    }();

    ProductManagementComponent.ɵfac = function ProductManagementComponent_Factory(t) {
      return new (t || ProductManagementComponent)();
    };

    ProductManagementComponent.ɵcmp = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineComponent"]({
      type: ProductManagementComponent,
      selectors: [["app-product-management"]],
      decls: 2,
      vars: 0,
      template: function ProductManagementComponent_Template(rf, ctx) {
        if (rf & 1) {
          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementStart"](0, "p");

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵtext"](1, "product-management works!");

          _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵelementEnd"]();
        }
      },
      styles: ["\n/*# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbXSwibmFtZXMiOltdLCJtYXBwaW5ncyI6IiIsImZpbGUiOiJzcmMvYXBwL2NvbXBvbmVudHMvcHJvZHVjdC1tYW5hZ2VtZW50L3Byb2R1Y3QtbWFuYWdlbWVudC5jb21wb25lbnQuY3NzIn0= */"]
    });
    /*@__PURE__*/

    (function () {
      _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵsetClassMetadata"](ProductManagementComponent, [{
        type: _angular_core__WEBPACK_IMPORTED_MODULE_0__["Component"],
        args: [{
          selector: 'app-product-management',
          templateUrl: './product-management.component.html',
          styleUrls: ['./product-management.component.css']
        }]
      }], function () {
        return [];
      }, null);
    })();
    /***/

  },

  /***/
  "./src/app/components/product-management/product-management.module.ts":
  /*!****************************************************************************!*\
    !*** ./src/app/components/product-management/product-management.module.ts ***!
    \****************************************************************************/

  /*! exports provided: ProductManagementModule */

  /***/
  function srcAppComponentsProductManagementProductManagementModuleTs(module, __webpack_exports__, __webpack_require__) {
    "use strict";

    __webpack_require__.r(__webpack_exports__);
    /* harmony export (binding) */


    __webpack_require__.d(__webpack_exports__, "ProductManagementModule", function () {
      return ProductManagementModule;
    });
    /* harmony import */


    var _angular_core__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(
    /*! @angular/core */
    "./node_modules/@angular/core/__ivy_ngcc__/fesm2015/core.js");
    /* harmony import */


    var _angular_common__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(
    /*! @angular/common */
    "./node_modules/@angular/common/__ivy_ngcc__/fesm2015/common.js");
    /* harmony import */


    var _product_management_product_management_component__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(
    /*! ../product-management/product-management.component */
    "./src/app/components/product-management/product-management.component.ts");
    /* harmony import */


    var _angular_router__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(
    /*! @angular/router */
    "./node_modules/@angular/router/__ivy_ngcc__/fesm2015/router.js");

    var routes = [{
      path: 'start',
      component: _product_management_product_management_component__WEBPACK_IMPORTED_MODULE_2__["ProductManagementComponent"]
    }];

    var ProductManagementModule = function ProductManagementModule() {
      _classCallCheck(this, ProductManagementModule);
    };

    ProductManagementModule.ɵmod = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineNgModule"]({
      type: ProductManagementModule
    });
    ProductManagementModule.ɵinj = _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵdefineInjector"]({
      factory: function ProductManagementModule_Factory(t) {
        return new (t || ProductManagementModule)();
      },
      imports: [[_angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"], _angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"].forChild(routes)]]
    });

    (function () {
      (typeof ngJitMode === "undefined" || ngJitMode) && _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵɵsetNgModuleScope"](ProductManagementModule, {
        declarations: [_product_management_product_management_component__WEBPACK_IMPORTED_MODULE_2__["ProductManagementComponent"]],
        imports: [_angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"], _angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"]]
      });
    })();
    /*@__PURE__*/


    (function () {
      _angular_core__WEBPACK_IMPORTED_MODULE_0__["ɵsetClassMetadata"](ProductManagementModule, [{
        type: _angular_core__WEBPACK_IMPORTED_MODULE_0__["NgModule"],
        args: [{
          declarations: [_product_management_product_management_component__WEBPACK_IMPORTED_MODULE_2__["ProductManagementComponent"]],
          imports: [_angular_common__WEBPACK_IMPORTED_MODULE_1__["CommonModule"], _angular_router__WEBPACK_IMPORTED_MODULE_3__["RouterModule"].forChild(routes)]
        }]
      }], null, null);
    })();
    /***/

  }
}]);
//# sourceMappingURL=components-product-management-product-management-module-es5.js.map