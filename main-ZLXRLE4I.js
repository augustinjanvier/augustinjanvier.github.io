import{a as h,b as M,c as C}from"./chunk-GYNZMNTI.js";import{a as r,b as l,c as i,i as m,j as p,k as n,r as d,s as c,u,y as f,z as s}from"./chunk-5DN4F4UU.js";var v=(()=>{let t=class t{constructor(){}};t.\u0275fac=function(e){return new(e||t)},t.\u0275cmp=l({type:t,selectors:[["app-root"]],decls:5,vars:0,consts:[[1,"wrapper"],[1,"main-content"]],template:function(e,S){e&1&&(m(0,"div",0),n(1,"app-header"),m(2,"div",1),n(3,"router-outlet"),p(),n(4,"app-footer"),p())},dependencies:[u,h,M]});let o=t;return o})();var N=[{path:"home",loadChildren:()=>import("./chunk-G3LSNEQD.js").then(o=>o.HomeModule),title:"Augustin Janvier"},{path:"about",loadChildren:()=>import("./chunk-A6GADXU3.js").then(o=>o.AboutModule),title:"Augustin Janvier - \xC0 propos"},{path:"portfolio",loadChildren:()=>import("./chunk-LDKSJWPD.js").then(o=>o.PortfolioModule),title:"Augustin Janvier - Mes projets"},{path:"contact",loadChildren:()=>import("./chunk-NFZWBPID.js").then(o=>o.ContactModule),title:"Augustin Janvier - Contact"},{path:"**",redirectTo:"home"}],y=(()=>{let t=class t{};t.\u0275fac=function(e){return new(e||t)},t.\u0275mod=i({type:t}),t.\u0275inj=r({imports:[s.forRoot(N,{preloadingStrategy:f,scrollPositionRestoration:"enabled"}),s]});let o=t;return o})();var b=(()=>{let t=class t{};t.\u0275fac=function(e){return new(e||t)},t.\u0275mod=i({type:t,bootstrap:[v]}),t.\u0275inj=r({imports:[c,y,C]});let o=t;return o})();d().bootstrapModule(b).catch(o=>console.log(o));
