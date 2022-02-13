import 'package:flutter/material.dart';
import 'package:growth_mobile/widgets/background.dart';

class Welcome extends StatelessWidget {
  const Welcome({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return const Scaffold(
        body: Center(
      child: Background(),
    ));
  }
}
