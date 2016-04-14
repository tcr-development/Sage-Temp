import {Router, RouterConfiguration} from "aurelia-router";

export class App {
   router: Router;

   configureRouter(config: RouterConfiguration, router: Router) {
      config.title = "PlanAdvisor Companies";
      config.map([
         { route: [""], name: "home", moduleId: "./companies", nav: true, title: "All Companies" },
         { route: "detail/:id", name: "detail", moduleId: "./company-detail", nav: false, title: "Detail"}
      ]);

      this.router = router;
   }
}