function get_results_theme_ver() {
    debug("results theme hook " + string(global.count_miss));
    if (global.count_miss == 0) {
        return 2000;
    } else {
        return 3000;
    }
}