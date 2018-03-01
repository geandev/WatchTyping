import { RouterModule, Routes } from "@angular/router";
import { PaperComponent } from "./components/paper/paper.component";
import { JoinComponent } from "./components/join/join.component";

const appRoutes: Routes = [
    { path: 'paper', component: PaperComponent },
    { path: '**', component: JoinComponent },
];

export const AppRouteModule = RouterModule.forRoot(
    appRoutes
);